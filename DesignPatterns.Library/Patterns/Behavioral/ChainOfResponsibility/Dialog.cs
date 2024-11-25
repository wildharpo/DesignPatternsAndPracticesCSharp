using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Library.Patterns.Behavioral.ChainOfResponsibility
{
    public class Dialog : Widget
    {
        private readonly Topic _topic;

        public Dialog(HelpHandler parent, Topic topic = Topic.NO_HELP_TOPIC) : base(null, topic)
        {
            _topic = topic;
        }

        public override void HandleHelp()
        {
            if (HasHelp())
                TopicHandler.DisplayHelp(_topic);
            else
                base.HandleHelp();
        }
    }
}
