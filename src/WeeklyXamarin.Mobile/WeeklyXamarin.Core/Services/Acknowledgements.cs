﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WeeklyXamarin.Core.Services
{
    public enum Activity
    {
        Follow,
        Subscribe,
        Raid,
        PullRequest,
        Bitties,
        DerailedEverything,
        GiftSub,
        WriteTheThemeTune
    }

    public class Acknowledgement
    {
        public string Person { get; set; }
        public Activity Activity { get; set; }
    }

    public class Acknowledgements
    {
        public IList<Acknowledgement> Thanks = new List<Acknowledgement>();

        public Acknowledgements()
        {
            Thanks = new List<Acknowledgement>()
            {
                // new Acknowledgement() {Person="", Activity=Activity.Follow},


                // 2 September 2020
                new Acknowledgement() {Person="TendedDinosaur2", Activity=Activity.Follow },
                new Acknowledgement() {Person="AndikaRizary", Activity=Activity.Follow },
                new Acknowledgement() {Person="jazteng2", Activity=Activity.Follow },
                new Acknowledgement() {Person="GlennStephens", Activity=Activity.WriteTheThemeTune },
                new Acknowledgement() {Person="Iceist", Activity=Activity.Follow },
                new Acknowledgement() {Person="ScottDev", Activity=Activity.DerailedEverything },
                new Acknowledgement() {Person="ScottDev", Activity=Activity.GiftSub },
                new Acknowledgement() {Person="ScottDev", Activity=Activity.Subscribe },
                new Acknowledgement() {Person="varrathien", Activity=Activity.Subscribe },
                new Acknowledgement() {Person="jhsebas", Activity=Activity.Follow },
                new Acknowledgement() {Person="varrathien", Activity=Activity.Follow },
                new Acknowledgement() {Person="DavidWengier", Activity=Activity.Raid},
                new Acknowledgement() {Person="BitwyzeGaming", Activity=Activity.Follow},
                new Acknowledgement() {Person="eldoen", Activity=Activity.Follow},


                // 26 August 2020
                new Acknowledgement() {Person="kenthtet", Activity=Activity.Follow},
                new Acknowledgement() {Person="zetawop", Activity=Activity.Follow},
                new Acknowledgement() {Person="DavidWengier", Activity=Activity.Raid},
                new Acknowledgement() {Person="scarlettcode", Activity=Activity.Follow},

                // 12 August 2020
                new Acknowledgement() {Person="agentesimoes", Activity=Activity.Follow},
                new Acknowledgement() {Person="xxxless", Activity=Activity.Follow },
                new Acknowledgement() {Person="Tondi", Activity=Activity.Follow },
                new Acknowledgement() {Person="nativelinux", Activity=Activity.Follow },
                new Acknowledgement() {Person="tbdgamer", Activity=Activity.DerailedEverything },
                new Acknowledgement() {Person="BenBtg", Activity=Activity.Follow},
                new Acknowledgement() {Person="Simontaga", Activity=Activity.Follow},
                new Acknowledgement() {Person="Simontaga", Activity=Activity.Follow},
                new Acknowledgement() {Person="le_BigSid", Activity=Activity.Follow},
                new Acknowledgement() {Person="EdNascimento31", Activity=Activity.Follow},
                new Acknowledgement() {Person="bricemarcelkouadio", Activity=Activity.Follow},
                new Acknowledgement() {Person="Asterisix", Activity=Activity.Subscribe},
                new Acknowledgement() {Person="zaploator", Activity=Activity.Follow},
                new Acknowledgement() {Person="marcosapoggi", Activity=Activity.Follow},
                new Acknowledgement() {Person="skullteria", Activity=Activity.Follow},
                new Acknowledgement() {Person="elianax_2000", Activity=Activity.Follow},
                new Acknowledgement() {Person="r2_au", Activity=Activity.Bitties},
                new Acknowledgement() {Person="jfversluis", Activity=Activity.Bitties},
                new Acknowledgement() {Person="jfversluis", Activity=Activity.Subscribe},
                new Acknowledgement() {Person="mdebruin93", Activity=Activity.Follow},
                new Acknowledgement() {Person="@vortexcdn", Activity=Activity.Follow},
                new Acknowledgement() {Person="@programmetajs", Activity=Activity.Follow},
                new Acknowledgement() {Person="@KevinQAnderson", Activity=Activity.Subscribe},


                // 5 August 2020
                new Acknowledgement() {Person="riallymundane", Activity=Activity.Raid},
                new Acknowledgement() {Person="Superbeer1994", Activity=Activity.Follow},
                new Acknowledgement() {Person="informationrocket", Activity=Activity.Follow},
                new Acknowledgement() {Person="STuaRTRuLes", Activity=Activity.Follow},
                new Acknowledgement() {Person="StevenThewissen", Activity=Activity.Follow},
                new Acknowledgement() {Person="fr33k3r", Activity=Activity.Follow},
                new Acknowledgement() {Person="DavidWengier", Activity=Activity.Raid},
                new Acknowledgement() {Person="deva73", Activity=Activity.Follow},
                new Acknowledgement() {Person="pickpie", Activity=Activity.Follow},
                new Acknowledgement() {Person="vishop_vishwa", Activity=Activity.Follow},
                new Acknowledgement() {Person="codingwithLuce", Activity=Activity.PullRequest},
            };
        }
    }
}
