﻿using System;
using Newtonsoft.Json;
using PUBGLibrary.Replay;
using PUBGLibrary.API;
using PUBGLibrary.Utils;

namespace LibraryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            APIMethod();
            Console.ReadLine();
        }
        static void ReplayMethod()
        {
            string replay_path = @"C:\Users\Master\AppData\Local\TslGame\Saved\Demos\old\match.bro.custom.1cePrime.na.normal.2018.02.02.feef46c6-0c69-49ea-a0fe-3853d41aacb1__USER__3f2737e1fcd7d5e0444298f528c41675";
            Replay replay = new Replay(replay_path);
            Console.WriteLine("CustomName = " + replay.CustomName);
            Console.WriteLine("Path = " + replay.Path);
            Console.WriteLine("Info - AllDeadOrWin = " + replay.Info.AllDeadOrWin);
            Console.WriteLine("Info - Changelist = " + replay.Info.Changelist);
            Console.WriteLine("Info - CustomHost = " + replay.Info.CustomHost);
            Console.WriteLine("Info - DemoFileLastOffset = " + replay.Info.DemoFileLastOffset);
            Console.WriteLine("Info - FriendlyName = " + replay.Info.FriendlyName);
            Console.WriteLine("Info - IsIncomplete = " + replay.Info.IsIncomplete);
            Console.WriteLine("Info - IsLive = " + replay.Info.IsLive);
            Console.WriteLine("Info - IsServerRecording = " + replay.Info.IsServerRecording);
            Console.WriteLine("Info - LengthInMs = " + replay.Info.LengthInMs);
            Console.WriteLine("Info - MapName = " + replay.Info.MapName);
            Console.WriteLine("Info - Mode = " + replay.Info.Mode);
            Console.WriteLine("Info - NetworkVersion = " + replay.Info.NetworkVersion);
            Console.WriteLine("Info - RecordUserId = " + replay.Info.RecordUserId);
            Console.WriteLine("Info - RecordUserNickName = " + replay.Info.RecordUserNickName);
            Console.WriteLine("Info - ServerID = " + replay.Info.ServerID);
            Console.WriteLine("Info - ServerType = " + replay.Info.ServerType);
            Console.WriteLine("Info - ShouldKeep = " + replay.Info.ShouldKeep);
            Console.WriteLine("Info - SizeInBytes = " + replay.Info.SizeInBytes);
            Console.WriteLine("Info - TimeStampISO = " + replay.Info.TimeStampISO);
            Console.WriteLine("Info - TimeStamp = " + replay.Info.TimeStamp);
            Console.WriteLine("Info - HasReplayReportToken = " + replay.Info.HasReplayToken);
            Console.WriteLine("Summary - MatchID = " + replay.Summary.MatchID);
            Console.WriteLine("Summary - IsServerRecording = " + replay.Summary.IsServerRecording);
            Console.WriteLine("Summary - PlayerCount = " + replay.Summary.PlayerCount);
            Console.WriteLine("Summary - TeamsCount = " + replay.Summary.TeamsCount);
            Console.WriteLine("Summary - AvgPlayerPerTeam = " + replay.Summary.AvgPlayersPerTeam);
            Console.WriteLine("Summary - NumTeammates = " + replay.Summary.NumTeammates);
            Console.WriteLine("Summary - District = " + replay.Summary.District);
            Console.WriteLine("Summary - KnownRegion = " + replay.Summary.KnownRegion);
            Console.WriteLine("Summary - KnownWeather = " + replay.Summary.KnownWeather);
            Console.WriteLine("Summary - Climate = " + replay.Summary.Climate);
            for (int i = 0; i < replay.Summary.NumTeammates; i++)
            {
                Console.WriteLine("Summary - Teammate " + (i + 1) + " - Player Name = " + replay.Summary.Teammates[i].PlayerName);
                Console.WriteLine("Summary - Teammate " + (i + 1) + " - Player ID = " + replay.Summary.Teammates[i].PlayerID);
                Console.WriteLine("Summary - Teammate " + (i + 1) + " - TeamID = " + replay.Summary.Teammates[i].PlayerTeamID);
                Console.WriteLine("Summary - Teammate " + (i + 1) + " - IsRecordingPlayer = " + replay.Summary.Teammates[i].IsRecordingUser);
                Console.WriteLine("Summary - Teammate " + (i + 1) + " - Kills = " + replay.Summary.Teammates[i].Kills);
                Console.WriteLine("Summary - Teammate " + (i + 1) + " - Headshots = " + replay.Summary.Teammates[i].Headshots);
                Console.WriteLine("Summary - Teammate " + (i + 1) + " - Ranking = " + replay.Summary.Teammates[i].Ranking);
                Console.WriteLine("Summary - Teammate " + (i + 1) + " - Longest Distance Kill In CM = " + replay.Summary.Teammates[i].LongestDistanceKillInCM);
                Console.WriteLine("Summary - Teammate " + (i + 1) + " - Longest Distance Kill In M = " + replay.Summary.Teammates[i].LongestDistanceKillInM);
                Console.WriteLine("Summary - Teammate " + (i + 1) + " - Total Damage = " + replay.Summary.Teammates[i].TotalGivenDamages);
                Console.WriteLine("Summary - Teammate " + (i + 1) + " - Total Distance Moved in M = " + replay.Summary.Teammates[i].TotalMovedDistanceInM);
                Console.WriteLine("Summary - Teammate " + (i + 1) + " - Total Distance Moved (in M or KM) = " + replay.Summary.Teammates[i].TotalMovedDistanceHumanReadable);
            }
            if (replay.Info.HasReplayToken)
            {
                Console.WriteLine("Info - ReplayReportToken - Token = " + replay.Info.ReplayReportToken.Token);
                Console.WriteLine("Info - ReplayReportToken - Algorithm = " + replay.Info.ReplayReportToken.Algorithm);
                Console.WriteLine("Info - ReplayReportToken - Type = " + replay.Info.ReplayReportToken.Type);
                Console.WriteLine("Info - ReplayReportToken - AccountID = " + replay.Info.ReplayReportToken.AccountID);
                Console.WriteLine("Info - ReplayReportToken - MatchID = " + replay.Info.ReplayReportToken.MatchID);
                Console.WriteLine("Info - ReplayReportToken - JWT_ID = " + replay.Info.ReplayReportToken.JWT_ID);
                Console.WriteLine("Info - ReplayReportToken - NotBefore = " + replay.Info.ReplayReportToken.NotBefore);
                Console.WriteLine("Info - ReplayReportToken - NotBeforePrecise = " + replay.Info.ReplayReportToken.NotBeforePrecise);
                Console.WriteLine("Info - ReplayReportToken - Expires = " + replay.Info.ReplayReportToken.Expires);
                Console.WriteLine("Info - ReplayReportToken - ExpiresPercise = " + replay.Info.ReplayReportToken.ExpiresPrecise);
                Console.WriteLine("Info - ReplayReportToken - Issuer = " + replay.Info.ReplayReportToken.Issuer);
                Console.WriteLine("Info - ReplayReportToken - Signature = " + replay.Info.ReplayReportToken.Signature);
            }
            Console.WriteLine("--- Events ---");
            foreach (IReplayEvent Event in replay.Events())
            {
                switch (Event.GetType().Name)
                {
                    case "ReplayKnockEvent":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(Event.ToString());
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                    case "ReplayKillEvent":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(Event.ToString());
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                    default:
                        Console.WriteLine(Event.ToString());
                        break;
                }
            }
            Console.WriteLine("---- All Replays ----");
            foreach (Replay singlereplay in Utils.ListReplays(Utils.default_replay_dir))
            {
                Console.WriteLine(singlereplay.Info.FriendlyName);
            }
            Console.WriteLine("---- End Replays ----");


        }
        static void APIMethod()
        {
            APIStatus APIStatus = new APIStatus();
            Console.WriteLine("Status - IsOnline = " + APIStatus.bIsOnline);
            Console.WriteLine("Status - APIVerisonRelease = " + APIStatus.APIVersionRelease);
            Console.WriteLine("Status - ID = " + APIStatus.ID);

            APIRequest APIRequest = new APIRequest();
            Console.WriteLine(APIRequest.RequestSingleMatch("", "pc-na", "66748dee-1b34-4ce8-beff-0501c07f9392"));

        }
    }
}
