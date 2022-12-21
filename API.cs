using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


//THESE ARE THE COMMANDS 

//snow_mod



//teleport_waypoint


//teleport_mountchillad



//teleport_mazebank



//teleport_militarybase



//teleport_zancudotower


//teleport_maskshop



//teleport_lscustoms


//teleport_bennys


//teleport_ammunition



//teleport_airport


//teleport_waterfall



//teleport_LoliFbi


//teleport_humanlab



//teleport_sandyshoresairfield




//BlockNetworkEvents


//CarKick



//weathertimechange


//CEOKick


//CEOBAN



//sendtojob



//reqcon



//antikik



//antitp



//fire



//transactionspam




//explo



//freeze



//FXPARTICLES




//antibounty



//soundspam


//camcon



//ntofispam



//weaponhandle


//nonhostkick



//sendtosingleplayer



//rockstardev


//wantedprotection


//statprotection


//dropsprotection



//attachprotection



//vehiclefreeze



//cloneprotection



//invitehouseprotection


//infiniteloading



//antipassiveprotection


//organisastionprotection


//playertauntevent



//ragdollevent





//godmode


//nwanted



//sjump



//frun



//fastswim



//firehands


//slowmo



//refilarmor

//firebreathe


//noclip


//cleanplayer



//IgnoreNpc


//selfFreeze



//NoCollide


//clone


//DetachExtreme



//Camerazooom



//superpunch



//AutoHealth



//AutoArmor


//fastrun



//fly



//freecam




//Invisible



//updatepl




//OffRadar


//PlayerAlpha




//TinyPlayer


//Noragdoll


//Tinyplayer



//ff



//antiafk



//healplayer


//resetplayer



//dieed


//seatbelt


//waterproof



//rubberpunch




//flytoggle








//spawnin 
	 


//spawnwithmagic



//Maxedd



//weapons_whalegun




//abusive_clone 



//abusive_blame



//abusive_cage



//abusive_carkick



//abusive_carsetinto



//abusive_ramplayer


//abusive_impactloop



//abusive_airstrike



//abusive_clonevehicle



//abusive_removeweapons




//abusive_givewanted



//teleporttp




//teleporttV







//spectate




//teleporttp 
	 


//teleporttv



//abusive_removeweapons


//abusive_freeze


//abusive_explode



//abusive_burn


//abusive_taze



//abusive_poptires



//abusive_kick



//abusive_slingshotcar



//abusive_rpkick



//abusive_clonecrash



//abusive_ceokick



//abusive_ceoban


//abusive_transactionerror


//abusive_sendtojob



//abusive_infiniteloading


//abusive_insurancemessage




//abusive_spectatemessage



//abusive_idlekick


//abusive_fuckcamera


//abusive_sendpolice



//abusive_sendpolice


//helpful_moneydrop



//helpful_RPDROP



//helpful_DROPPARACHUTE



//helpful_DROPSNACKS


//helpful_DROPARMOR



//helpful_50KPEDDROP





//vehicleboost




//weapons_giveall



//weapons_givemk2



//weapons_infiniteamo



//weapons_norecoil



//weapons_nospread



//weapons_instantreload



//weapons_unlimitedrange



//weapons_onehitkill



//weapons_oneshotkill


//weapons_knockbackmeele



//weapons_rubberbullets



//weapons_gravitygun



//weapons_blockgun



//weapons_explosions


//weapons_rpgun



//weapons_moneygun



//weapons_deletegun



//weapons_explosiveamo



//weapons_pedswapgun



//weapons_meowgun



//weapons_explosiveME


//weapons_boxgun





//weapons_teleportgun





//Veh_Opacity



//Veh_Delete



//Veh_FixVeh



//Veh_MaxVeh



//Veh_KillEngine


//Veh_VehAlarm




//Veh_OpenDoors



//Veh_CloseDoors



//Veh_GodMode



//Veh_Bulletprooftires



//Veh_stanceveh



//Veh_flyv1



//Veh_flyv2



//Veh_EngineStandby


//Veh_JesusCar




//Veh_TokyoDr t 
	 


//Veh_ExhaustShootFlames


//Veh_ModRandomize



//Veh_SlowRainbow



//Veh_FastRainbow


//Veh_AutoFlip



//Veh_BurntBody




//Veh_UnlimitedBoost




//Veh_Invisible



//Veh_matrixplates


//Veh_fixloop


//Veh_Frog



//Veh_SuperGlue

//Veh_FastBreak



//Veh_PlateStyle



//Veh_Hornboost


	 
//	 Veh_ShootRockets 
	 


//Veh_ShootRedLasers


//Veh_alienparticle




//Veh_clownparticle



//Veh_alienxparticle


//Veh_lightningparticle



//Veh_ghostparticle


//Veh_electricparticle

	 

	 
//	 weapons_vehiclegun 
	 
		
	 
//	 Veh_FrontFlip 
	 
	 
//	 Veh_BackFlip 
	 

	 
//	 Veh_KickFlip 
	 

	 
//	 Veh_HeelFlip 
	 


	 
//	 Veh_BunnyHop 
	 

	 
//	 Veh_LaunchUP 


	 
//	 Veh_LaunchDOWN 
	 

	 
//	 Veh_RPM 
	 

	 
//	 Veh_EngineTorque 
	 

	 
//	 Veh_Headlights 
	 

	 
//	 VEHICLE_HANDLING 
	 

	 
//	 VEHICLE_HANDLING_BUOYANCY 
	 

	 
//	 VEHICLE_HANDLING_ACCELERATION 
	 

	 
//	 VEHICLE_HANDLING_UPSHIFT 
	 

	 
//	 VEHICLE_HANDLING_DOWNSHIFT 
	 

	 
//	 VEHICLE_HANDLING_BRAKEFORCE 
	 

	 
//	 VEHICLE_HANDLING_HANDBRAKEFORCE 
	 

	 
//	 VEHICLE_HANDLING_TRACTION_CURVE_MIN 
	 

	 
//	 VEHICLE_HANDLING_SUSPENSION_FORCE 
	 

	 
//	 VEHICLE_HANDLING_SUSPENSION_HEIGH 
	 

	 
//	 VEHICLE_HANDLING_COLISION_DAMAGE_MP 
	 

	 
//	 VEHICLE_HANDLING_WEAPON_DAMAGE_MP 
	 

	 
//	 VEHICLE_HANDLING_DEFORM_MULTIPLIER 
	 

	 
//	 VEHICLE_HANDLING_ENGINE_DAMAGE_MP 
	 

	 
//	 VEHICLE_BOMBS 
	 

	 
//	 VEHICLE_RECHARGE_SPEED 
	 

	 
//	 VEHICLE_GRAVITY 
	 

	 
//	 VEHICLE_MK2_MISSLES 
	 

	 
//	 VEHICLE_TAMPA_MISSLES 
	 

	 

//	 halloween_dlc1 
	 

	 
//	 halloween_dlc2 
	 

	 

//	 halloween_dlc3 
	 

	 

//	 halloween_dlc4 
	 

	 

//	 halloween_dlc5 
	 

	 

//	 halloween_dlc6 
	 

	 

//	 halloween_dlc7 
	 


//	 halloween_dlc8 
	 

		
	 

//	 halloween_dlc9 
	 

	 

//	 halloween_dlc10 
	 

	 
	
//	 halloween_dlc11

namespace ZeroUIAPIDemo
{
    public class API
    {
       

        public static void MessageBoxWarning(string message)
        {
            MessageBox.Show(message, "Zero", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void MessageBoxError(string message)
        {
            MessageBox.Show(message, "Zero", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void MessageBoxInfo(string message)
        {
            MessageBox.Show(message, "Zero", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void YouKnowWhatFuckIt5MSEXECUTIOOONN(string message)
        {
            
            StreamWriter sr = new StreamWriter("C:\\Zero\\DATARECIEVER\\DATA1.txt");
            sr.WriteLine(message);
            sr.Close();
        }
    }
}
