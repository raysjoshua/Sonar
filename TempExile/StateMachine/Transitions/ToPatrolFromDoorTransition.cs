﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Sonar {
    class ToPatrolFromOpenDoorTransition : Transition {
        //To patrol from opening that door he was stuck behind.
        public ToPatrolFromOpenDoorTransition(State s)
            : base(s) {
            condition = new BehindDoorCondition();
        }

        // Condition checked to see if the player is no longer close or in sight, then it will go to investigate.
        public override bool isTriggered(Spectre spectre, Player player) {
            return !condition.test(spectre, player);
        }

        // Transition to chase after having paused from alerted
        public override void doAction(Spectre spectre, Player player) {
            return;
        }
    }
}