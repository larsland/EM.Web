using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EM.Web.Models.Blocks
{
    [ContentType(DisplayName = "GameBlock", GUID = "0382c935-3ea8-48f7-aac9-4161428da77a", Description = "")]
    public class GameBlock : BlockData
    {
        public virtual string HomeTeam { get; set; }
        public virtual string AwayTeam { get; set; }
        public virtual DateTime StartDateTime { get; set; }
    }
}