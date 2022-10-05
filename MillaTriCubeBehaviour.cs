using UnityEngine;

namespace MillaTriCube.RisingSlash
{
    public class MillaTriCubeBehaviour : MonoBehaviour
    {
        private FPPlayer character = null;
        public void Update()
        {
            if (FPStage.currentStage != null)
            {
                if (character == null) 
                {
                    character = FPStage.currentStage.GetPlayerInstance_FPPlayer();
                }
                
                if (character != null && character.characterID == FPCharacterID.MILLA)
                {
                    if (character.input.guardPress)
                    {
                        /*
                        if (character.guardTime <= 0f 
                            && (character.input.guardPress || (character.input.guardHold && !character.input.attackPress)))
                            */
                        if ((character.input.guardPress || (character.input.guardHold && !character.input.attackPress)))
                        {
                            if (MillaTriCube.CubeNum.Value != 3)
                            {
                                character.Action_MillaCubeSpawnEx(MillaTriCube.CubeNum.Value);
                            }
                            else
                            {
                                character.Action_MillaCubeSpawn();
                            }
                        }
                    }
                }
            }
        }
    }

    public static class TriCubeExtension
    {
        public static void Action_MillaCubeSpawnEx(this FPPlayer fpp, int num)
        {
            if (fpp.cubeSpawned)
            {
                FPBaseObject fpbaseObject = null;
                while (FPStage.ForEach(MillaMasterCube.classID, ref fpbaseObject))
                {
                    MillaMasterCube millaMasterCube = (MillaMasterCube)fpbaseObject;
                    if (millaMasterCube.parentObject == fpp)
                    {
                        FPStage.ForEachCurrentStackRewind();
                        FPStage.DestroyStageObject(millaMasterCube);
                        num = Mathf.Min(num + 1, 6);
                    }
                }
            }
            for (int i = 0; i < num; i++)
            {
                MillaMasterCube millaMasterCube2 = (MillaMasterCube)FPStage.CreateStageObject(MillaMasterCube.classID, fpp.position.x, fpp.position.y);
                millaMasterCube2.parentObject = fpp;
                millaMasterCube2.cubeSpawnID = i;
                millaMasterCube2.floatStep = (float)i * -30f;
            }
            fpp.cubeSpawned = true;
            fpp.millaCubeEnergy = 100f;
            fpp.Action_PlaySoundUninterruptable(fpp.sfxMillaCubeSpawn);
        }
    }
}