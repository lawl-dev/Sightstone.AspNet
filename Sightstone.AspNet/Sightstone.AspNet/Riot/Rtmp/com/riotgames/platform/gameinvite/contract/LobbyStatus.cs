﻿using System;
using System.Collections.Generic;
using RtmpSharp.IO;

namespace Sightstone.AspNet.Riot.Rtmp.com.riotgames.platform.gameinvite.contract
{
    [Serializable]
    [SerializedName("com.riotgames.platform.gameinvite.contract.LobbyStatus")]
    public class LobbyStatus : IRiotRtmpObject
    {
        [SerializedName("chatKey")]
        public string ChatKey { get; set; }

        [SerializedName("gameMetaData")]
        public string GameData { get; set; }

        [SerializedName("owner")]
        public Player Owner { get; set; }
        //public Player Owner { get; set; }

        [SerializedName("members")]
        public List<Member> Members { get; set; }

        [SerializedName("invitees")]
        public List<Invitee> Invitees { get; set; }

        [SerializedName("invitationId")]
        public string InvitationID { get; set; }
    }
}
