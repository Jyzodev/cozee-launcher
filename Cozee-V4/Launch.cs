using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using Microsoft.Toolkit.Uwp.Notifications;
using Windows.Media.Protection.PlayReady;
using static Cozee_V4.UC_HOME;

namespace Cozee_V4
{
    internal class Launch
    {
        

        static Process FortniteClient = new Process();
        static Process FortniteEAC = new Process();
        static Process FortniteLauncher = new Process();
        static Process lawin = new Process();

        static String idkkk = AppDomain.CurrentDomain.BaseDirectory;
        public static void LaunchGame(String username, String boxText, String rpcThing)
        {
            if(Directory.Exists(boxText + "\\FortniteGame\\") && Directory.Exists(boxText + "\\Engine\\")){
                new ToastContentBuilder() // Show notification
                    .AddText("Starting Fortnite")
                    .AddText($@"Version name : {rpcThing}")
                    .Show();

                LawinServer(); // Start LawinServer
                LoadDiscordRPC(rpcThing); // Load discord RPC
                FClient(username, boxText); // Launch Fortnite
            } else if (Directory.Exists(boxText)){
                MessageBox.Show("Invalid Path");
            } else
            {
                MessageBox.Show("Cringe path");
            }
            

        }

        private static void LoadDiscordRPC(String verName) // Discord rpc with Lachee package
        {
            RichPresence presence = new RichPresence();
            DiscordRpcClient client = new DiscordRpcClient("1016663262730928210");
            bool bIsRPCEnabled = false;
            if (bIsRPCEnabled == false)
            {
                client.Initialize();
                presence.Details = $@"Playing : '{verName}'";
                presence.State = "using Cozee Launcher";
                presence.Buttons = new DiscordRPC.Button[]
                    {
                    new DiscordRPC.Button() { Label = "Discord", Url = "https://discord.gg/BRt67UMFMU" }
                    };
                presence.Assets = new Assets()
                {
                    LargeImageKey = "cozee",
                    LargeImageText = "OG Fortnite Multiplayer"
                };
                client.SetPresence(presence);
                bIsRPCEnabled = true;
            }

        }

        private static void LawinServer() // LawinServer by Lawin#0001
        {
            lawin.StartInfo.FileName = @"server/node.exe";
            lawin.StartInfo.Arguments = @"index.js";
            lawin.StartInfo.WorkingDirectory = idkkk + "\\server\\"; // idkk maybe needed
            lawin.StartInfo.UseShellExecute = false;
            lawin.StartInfo.CreateNoWindow = true; lawin.StartInfo.RedirectStandardOutput = true;
            lawin.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            lawin.Start();
        }

        private static void FClient(String username, String usedBoxText) // Launch Fortnite Client xD
        {
                FortniteLauncher.StartInfo.FileName = $@"{usedBoxText}\\FortniteGame\\Binaries\\Win64\\FortniteLauncher.exe";
                FortniteLauncher.StartInfo.WorkingDirectory = $@"{usedBoxText}\\FortniteGame\\Binaries\\Win64\\";
                FortniteLauncher.Start();
                ProcessExtension.Suspend(FortniteLauncher);

                FortniteEAC.StartInfo.FileName = $@"{usedBoxText}\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_EAC.exe";
                FortniteEAC.StartInfo.WorkingDirectory = $@"{usedBoxText}\\FortniteGame\\Binaries\\Win64\\";
                FortniteEAC.Start();
                ProcessExtension.Suspend(FortniteEAC);

                FortniteClient.StartInfo.FileName = $@"{usedBoxText}\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe";
                FortniteClient.StartInfo.WorkingDirectory = $@"{usedBoxText}\\FortniteGame\\Binaries\\Win64\\";
                FortniteClient.StartInfo.Arguments = $@"-epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal -skippatchcheck -nobe -fromfl=eac -fltoken=3db3ba5dcbd2e16703f3978d -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiYmU5ZGE1YzJmYmVhNDQwN2IyZjQwZWJhYWQ4NTlhZDQiLCJnZW5lcmF0ZWQiOjE2Mzg3MTcyNzgsImNhbGRlcmFHdWlkIjoiMzgxMGI4NjMtMmE2NS00NDU3LTliNTgtNGRhYjNiNDgyYTg2IiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.VAWQB67RTxhiWOxx7DBjnzDnXyyEnX7OljJm-j2d88G_WgwQ9wrE6lwMEHZHjBd1ISJdUO1UVUqkfLdU5nofBQ -AUTH_LOGIN={username}@cozeefn.dev -AUTH_PASSWORD=idfkkk -AUTH_TYPE=epic";
                FortniteClient.EnableRaisingEvents = true;
                FortniteClient.Exited += client_Exit;
                FortniteClient.Start();


                Process.Start($@"{idkkk}\\Client\\injector.exe", $@"-p {FortniteClient.Id} -i Cranium.dll");

                Process dllInjector = new Process();
                dllInjector.StartInfo.FileName = $@"{idkkk}\\Client\\injector.exe";
                dllInjector.StartInfo.UseShellExecute = false;
                dllInjector.StartInfo.CreateNoWindow = true; dllInjector.StartInfo.RedirectStandardOutput = true;
                dllInjector.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                dllInjector.StartInfo.WorkingDirectory = idkkk + "\\Client\\";

                DialogResult dialogResult = MessageBox.Show(
                "Press Yes when you are in lobby",
                "Cozee",
                MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    dllInjector.StartInfo.Arguments = $@"-p {FortniteClient.Id} -i Console.dll";
                    dllInjector.Start();

                    dllInjector.StartInfo.Arguments = $@"-p {FortniteClient.Id} -i Cozee.dll";
                    dllInjector.Start();
                }
            
        }

        static void client_Exit(object sender, EventArgs e)
        {
            ProcessExtension.Resume(FortniteEAC);
            ProcessExtension.Resume(FortniteLauncher);
            FortniteEAC.Kill();
            FortniteLauncher.Kill();
            try
            {
                lawin.Kill();
            } catch { }
        }
    }
}
