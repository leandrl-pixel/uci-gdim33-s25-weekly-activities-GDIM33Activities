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

    public class RelevantClassNameHere: EventUnit<DialogueNode> { }
    public override EventHook GetHook(GraphReference reference)
    {
        return new EventHook(EventNames.YourEventNameHere);
    }


}
