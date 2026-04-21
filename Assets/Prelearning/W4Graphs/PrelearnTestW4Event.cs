using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class PrelearnTestW4Event : MonoBehaviour
{
    public static class EventNames
    {
        public static string YourEventNameHere = "EventName";
    }

    [UnitTitle("On Your Event Name")]
    [UnitCategory("Events\\MyEvents")]
    public class RelevantClassNameHere : EventUnit<DialogueNode>
    {
        [DoNotSerialize]
        public ValueOutput Result { get; private set; }

        protected override bool register => true;

        protected override void Definition()
        {
            base.Definition();
            Result = ValueOutput<DialogueNode>(nameof(Result));
        }

        public override EventHook GetHook(GraphReference reference)
        {
            return new EventHook(EventNames.YourEventNameHere);
        }

        protected override void AssignArguments(Flow flow, DialogueNode data)
        {
            flow.SetValue(Result, data);
        }
    }
}