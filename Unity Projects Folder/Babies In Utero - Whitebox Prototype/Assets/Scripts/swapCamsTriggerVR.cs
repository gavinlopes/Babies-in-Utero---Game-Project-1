using UnityEngine;

public class swapCamsTriggerVR : MonoBehaviour
{
    public DropDown_SO dropDownSO;
	
    // Update is called once per frame
    public void swapCams()
    {
        if (dropDownSO.DropdownIndex == 1)
        {
            dropDownSO.DropdownIndex = 0;
        }
        else
        {
            dropDownSO.DropdownIndex = 1;
        }
    }
}
