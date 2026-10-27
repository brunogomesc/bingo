using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Bingo.Utils
{
    public class GameState
    {
        public List<GameLabelState> Labels { get; set; } = new();
        public int[] BallsDrawn { get; set; } = Array.Empty<int>();
        public int CurrentBall { get; set; }
        public int NextPositionBX { get; set; } = -1;
        public int NextPositionBY { get; set; } = -1;
        public int NextPositionIX { get; set; } = -1;
        public int NextPositionIY { get; set; } = -1;
        public int NextPositionNX { get; set; } = -1;
        public int NextPositionNY { get; set; } = -1;
        public int NextPositionGX { get; set; } = -1;
        public int NextPositionGY { get; set; } = -1;
        public int NextPositionOX { get; set; } = -1;
        public int NextPositionOY { get; set; } = -1;
    }

    public class GameLabelState
    {
        public int Number { get; set; }
        public int X { get; set; } = -1;
        public int Y { get; set; } = -1;
    }

    public static class GameStateStore
    {
        private static string GetFilePath(string? filePath)
        {
            return filePath ?? Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "Bingo", "partida.json");
        }

        public static void Save(GameState state, string? filePath = null)
        {
            string? temporaryPath = null;
            try
            {
                if (state.BallsDrawn.Length == 0)
                {
                    Clear(filePath);
                    return;
                }

                if (!IsValid(state)) return;

                string path = Path.GetFullPath(GetFilePath(filePath));
                Directory.CreateDirectory(Path.GetDirectoryName(path)!);
                temporaryPath = path + "." + Guid.NewGuid().ToString("N") + ".tmp";
                using (var stream = new FileStream(temporaryPath, FileMode.CreateNew, FileAccess.Write))
                {
                    JsonSerializer.Serialize(stream, state);
                    stream.Flush(true);
                }
                File.Move(temporaryPath, path, true);
            }
            catch
            {
                // Persistence failures must not interrupt the game.
            }
            finally
            {
                if (temporaryPath != null) Clear(temporaryPath);
            }
        }

        public static GameState? Load(string? filePath = null)
        {
            try
            {
                using var stream = File.OpenRead(GetFilePath(filePath));
                var state = JsonSerializer.Deserialize<GameState>(stream);
                return IsValid(state) ? state : null;
            }
            catch
            {
                return null;
            }
        }

        public static void Clear(string? filePath = null)
        {
            try
            {
                File.Delete(GetFilePath(filePath));
            }
            catch
            {
                // Persistence failures must not interrupt the game.
            }
        }

        private static bool IsValid(GameState? state)
        {
            if (state == null || state.Labels == null || state.BallsDrawn == null) return false;
            if (state.BallsDrawn.Length < 1 || state.BallsDrawn.Length > 75
                || state.Labels.Count != state.BallsDrawn.Length) return false;
            if (state.BallsDrawn.Any(number => number < 1 || number > 75)
                || state.BallsDrawn.Distinct().Count() != state.BallsDrawn.Length) return false;
            if (state.Labels.Any(label => label == null || label.Number < 1 || label.Number > 75
                || label.X < 0 || label.Y < 0)) return false;
            if (state.Labels.Select(label => label.Number).Distinct().Count() != state.Labels.Count
                || !state.Labels.Select(label => label.Number).ToHashSet().SetEquals(state.BallsDrawn)) return false;

            // CurrentBall can refer to a number that was subsequently removed.
            return state.CurrentBall >= 1 && state.CurrentBall <= 75
                && state.NextPositionBX >= 0
                && state.NextPositionBY >= 0
                && state.NextPositionIX >= 0
                && state.NextPositionIY >= 0
                && state.NextPositionNX >= 0
                && state.NextPositionNY >= 0
                && state.NextPositionGX >= 0
                && state.NextPositionGY >= 0
                && state.NextPositionOX >= 0
                && state.NextPositionOY >= 0;
        }
    }
}
