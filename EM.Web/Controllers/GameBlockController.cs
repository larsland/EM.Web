using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EM.Web.Models.Blocks;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;

namespace EM.Web.Controllers
{
    public class GameBlockController : BlockController<GameBlock>
    {
        public override ActionResult Index(GameBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
