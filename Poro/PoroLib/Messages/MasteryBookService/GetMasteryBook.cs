﻿using PoroLib.Structures;
using RtmpSharp.Messaging;
using System.Collections.Generic;

namespace PoroLib.Messages.MasteryBookService
{
    class GetMasteryBook : IMessage
    {
        public RemotingMessageReceivedEventArgs HandleMessage(object sender, RemotingMessageReceivedEventArgs e)
        {
            MasteryBookDTO MasteryBook = new MasteryBookDTO
            {
                SummonerId = int.MaxValue - 1,
                DateString = "Wed Apr 23 00:33:57 PDT 2014",
                BookPages = new List<MasteryBookPageDTO>
                        {
                            new MasteryBookPageDTO
                            {
                                Current = true,
                                SummonerId = int.MaxValue - 1,
                                PageId = 1.0,
                                Name = "Mastery Page 1",
                                TalentEntries = new List<TalentEntry>()
                            }
                        }
            };

            e.ReturnRequired = true;
            e.Data = MasteryBook;

            return e;
        }
    }
}
