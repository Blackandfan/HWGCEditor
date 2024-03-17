/*
 * Created by SharpDevelop.
 * User: blackandfan
 * 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace HWGCEditor
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
			string sCameraFOV = "";
			string sCameraYaw = "";
			string sCameraPitchMax = "";
			string sCameraPitch = "";
			string sCameraPitchMin = "";
			string sCameraZoomMax = "";
			string sCameraZoom = "";
			string sCameraZoomMin = "";
			string sPhysicsMainThread = "";
			string sNumPhysicsThreads = "";
			string sCameraLimit = "";
			string sLockCameraToWorld = "";
			string sFlashCovUI = "";
			string sFlashMinimap = "";
			string sFlashGameUI = "";
			string sEnableCorpses = "";
			string sPlayCinematicOnLoad = "";
			string sEnableAttractMode = "";
			string sNewSkirmish = "";
			string sNoHPBar = "";
			string sSelectAllIgnoreWorking = "";
			string sUseTestLeaders = "";
			string sNoIntroCinematics = "";
			string sLegacyIntro = "";
			string sLegacyIntro2 = "";
			string sPlayer1AI = "";
			string sRenderSquadPlotter = "";
			string sSubtitles = "";
			const string sremaining = @"
// DoNotChange
unlockAllCampaignMissions
CameraZoomRate=80.0
CameraZoomFastFactor=2.0
CameraRotateRate=160.0
CameraRotateFastFactor=1.0
CameraPitchRate=60.0
CameraPitchFastFactor=2.0
-CameraPitchInvert
CameraFOVRate=5.0
CameraAutoZoomOutRate=60.0
CameraAutoZoomOutFastFactor=1.0
CameraAutoZoomOutDelay=0.1
CameraAutoZoomInRate=80.0
CameraAutoZoomInFastFactor=1.0
CameraAutoZoomInDelay=0.1
CameraAutoZoomInstant
KeyboardPanSpeed=1.0
scrollMaxSpeed 100
scrollFastSpeed 400
scrollRampPoint 0.6
scrollRampSpeed 0.3
scrollExp 2.0
scrollRateBase 0.1
scrollRateGrow 1.5
delayScrollingAngle 20
delayScrollingTime 1.0
scrollBorderWidth 10
scrollCornerRegionPercent 20
StickyReticle
StickyReticleSensitivity 1.0
StickyReticleFollow
-StickyReticleJumpCamera
StickyReticleJumpCameraSpeed 40.0
StickyReticleJumpStep 1.0
StickyReticleJumpForwardMinSpeed 40.0
StickyReticleJumpForwardMaxSpeed 120.0
StickyReticleJumpForwardMinDist 4.0
StickyReticleJumpForwardMaxDist 16.0
StickyReticleJumpBackMinSpeed 40.0
StickyReticleJumpBackMaxSpeed 120.0
StickyReticleJumpBackMinDist 4.0
StickyReticleJumpBackMaxDist 16.0
StickyReticleJumpToAngleTolerance 45.0
StickyReticleJumpMaxSpeed 200.0
StickyReticleJumpMinSpeed 0.0
StickyReticleJumpMaxTime 0.8
StickyReticleJumpMinTime 0.1
StickyReticleJumpMinSearchScale 1.0
StickyReticleJumpMaxSearchScale 8.0
StickyReticleAverageSpeedInterval 1.0
circleSelectDelayTime 0.1
circleSelectRate 0.1
circleSelectRateAccel 225.0
circleSelectMaxRate 3000.0
circleSelectSize 0.6
circleSelectMaxSize 24.0
circleSelectMaxResize 24.0
circleSelectResizeRate 20.0
circleSelectFadeInAccel 80.0
circleSelectEventSize 18.0
circleSelectHover
-circleSelectDrawMax
circleSelectClickSize 40.0
-circleSelectAutoDoubleClick
debugCircleSelect 0
ControllerConfig New3
KeyboardMouseSchemeAllowed
UserGamepadRumble
GamepadDoubleClickTime 0.3
GamepadHoldTime 0.35
ActionWithDirectionHoldTime 0.25
ThreadInput
ConsoleStringLimit=500
-DisableUI
-NoHelp
BuildingMenuOnSelect
ExitSubSelectOnCancel
ExitTargetSelectOnScroll
-DisableFlash
CrowdNeighborDistance 80.0
GotoSlideTime 0.5
GotoSlideAwaySpeed 0.0
GotoSlideTowardsDistance 30.0
GroupCreateTime 0.5
GroupGotoTime 0.3
ShowUnavailIcons
BaseDecalIntensity 6.0
SelectionDecalIntensity 15.0
SubSelectDecalAlpha 0.4
ShowReticuleHelp
ObjectivesDisplay
Objectives2
ShowDebugMenuItems
HUDAttackNotification
ShowFlashObjWidget
ShowFlashChat
;UsePartyRoom
UsePartyRoom2
NewCampaignPostgame
NewCampaignObjectives
NewMainMenu
-SplitScreen
VerticalSplit
AIEye
CircleSelectIntensity 0.75
CircleSelectSizeFactor 0.59
CircleSelectOffset 0.1
HoverDecalSize 5.0
HoverDecalIntensity 3.0
HoverDecalOffset 0.1
RecoverEffectOffset -4.0
BillboardRecoverEffect
FriendOrFoe
UsePlayerMenu
-NewEndGame
NewSkirmishPostGame
NewSkirmishObjective
NewOptions
NoSelectionHighlight
StorageWaitMinTime 500
CreditsMovie=video\uiCredits.bik
CreditsSubtitles=cin17.eng.xml
UIBackgroundMovieMain=video\uiBackground1.bik
UIBackgroundMovie=video\uiBackground2.bik
UITimelineScreenMovie=video\uiBackgroundTimeline.bik
UIBackgroundImg=ui\menu\background\uiBackground1
UIBackgroundMovieCampaign=video\uiBackground1.bik
-NoVismap
UseVismapFile
-SaveVismapFil;
BlackMaskTint 0.0
DefaultMap=skirmish\design\beta_1v1_cross\beta_1v1_cross
-NoDamage
GameSpeed 1.0
-PassThroughOwnVehicles
-NoRandomPlayerPlacement
-UsePathEngine
-EnableCapturePointResourceSharing
ProjectionTime 0.6
//ProjectionCollisionRatio 0.6
//NoBirthAnims
//Turning
NewMovement
BuildingQueue
ActiveAbilities
MoreNewMovement3
AsyncWorldUpdate
ExplorationRegionShowTime=5.0
TrueLOS
CoopSharedResources
CoopSharedPop
MaxProjectileHeightForDecal=4.0
AllowAnimIsDirty
-IgnoreGrannyRootBone
-AllowFixedParentBone
PercentFadeTimeCorpseSink=0.75
CorpseSinkSpeed=0.5
CorpseMinScale=0.7
-BlockOutsideBounds
-NoProtoObjectOptimization
EnableSubUpdating
MPSubUpdating
AlternateSubUpdating
DynamicSubUpdateTime
MaxSubUpdateTime 66
DynamicSubUpdating
SubUpdateAvgUpdOn 25
SubUpdateAvgUpdOff 7
MinSubUpdateEnabledTime 10.0
ClassicPlatoonGrouping
UnloadRootArchive
Veterancy
-temporalAA
vsync 2
numAATiles 2
loadModelTextures
GammaExponent 2.645
TessellationShaders
ParticleDeferredContext
ModelPipelineCache
Multisampling
RejoinParty
UseLan
xNet-ProxySupport
syncManagerNoCompression
-NoSync
-DontGoOOS
FullAllSync
RenderFloatyTextXVelocity=0.00
RenderFloatyTextYVelocity=0.10
RenderFloatyTextDuration=1500
RenderFloatyTextFadeOutTime=1000
-noAssert
-noDebugSpew
-NoAssertDialog
autoIgnoreAssertAfterFirstHit
EnableGameStats
ShowPostGame
ShowCampaignPostGame
ShowTimeline
ShowLeaderboards
PlatoonRadius=50.0
-HumanAttackMove
EnableMotionExtraction
SuspendableTimeChecks
SuspendableAsserts
VinceUnitInterval=30.0
VinceBuildingInterval=30.0
VinceResourceInterval=30.0
-Demo
DemoFadeOutTime 5.0
TutorialMap=skirmish\design\labyrinth_walk_e3\labyrinth_walk_e3
DemoMovie=game:\video\HWE32008.bik
-AlphaTest
SocketUnresponsiveTimeout=15000
xNet-JoinRequestTimeout=30000
xNet-ProxyRequestTimeout=8000
xNet-ProxyPingTimeout=3000
xNet-UseAddressFragment
LSPServerFilter=HW_PROD
LSPServiceID=0x4D530838
LSPEnableFileUpload
-LSPEnableAuth
LSPEnableConfig
LSPConfigDataPacketVersion2
LSPEnablePerfReport
-LSPEnableMediaTransfer
-LSPEnableMediaCompression
-LSPEnableTicker
EnableXMB
OverrideGroundIKRange=5.0
OverrideGroundIKTiltFactor=0.1
EmitterFadeStartDistance=200.0
EmitterFadeEndDistance=300.0
EnableSubbreakage
EnableThrowPart
EnableBackgroundPlayer
SkirmishLoadScreen
FlashEnableBatching
EnableImpactLimits
NoWorldBorder
CircleMenuBlurFactor 0.4
CircleMenuBlurSaturation 0.5
CircleMenuBlurDuration 0.15
AIEye
-EnableTriggerDebugs
-EnableTriggerDebugsStatusText
EnableHintSystem
-GrannySampleAnimCache
EnableMusic
-ShowCinematicSubtitles
BackgroundTextureLoading
GameStartFadeTime 0.75
GameStartFadeDelay 0.25
ReloadScenarioIgnoreTime 2.0
ReloadScenarioWaitTime 1.0
-RecordToCacheDrive
CTFExtraDifficulty 0.3
OptionsMenuMaxItems 9
MaximumSPCLifetimeLeaderboardScore 60000000";
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnCreateClick(object sender, EventArgs e)
		{	
			// Set the custom vars
			try {	
				if (cCameraLimits.Checked == true) 
					{ 
						sCameraLimit = "CameraLimits";
				} else 
					{ 
						sCameraLimit = "-CameraLimits";
				}
				if (cLockCameraToWorld.Checked == true)
					{
						sLockCameraToWorld = "LockCameraToWorld";
				} else 
					{
						sLockCameraToWorld = "-LockCameraToWorld";
				}
				if (cFlashCovUI.Checked == true) 
					{ 
						sFlashCovUI = "FlashCovUI";
				} else 
					{
						sFlashCovUI = "-FlashCovUI"; 
				}
				if (cFlashMinimap.Checked == true) 
					{ 
						sFlashMinimap = "FlashMinimap";
				} else 
					{
						sFlashMinimap = "-FlashMinimap";
				}
				if (cFlashGameUI.Checked == true)
					{
						sFlashGameUI = "FlashGameUI";
				} else
					{
						sFlashGameUI = "-FlashGameUI";
				}
				if (cSubtitles.Checked == true)
					{
						sSubtitles = "SubTitles";
				} else
					{
						sSubtitles = "-SubTitles";
				}
				if (cEnableCorpses.Checked == true)
					{
						sEnableCorpses = "EnableCorpses";
				} else
					{
						sEnableCorpses = "-EnableCorpses";
				}
				if (cPlayCinematicOnLoad.Checked == true)
					{
						sPlayCinematicOnLoad = "PlayCinematicOnLoad";
				} else
					{
						sPlayCinematicOnLoad = "-PlayCinematicOnLoad";
				}
				if (cEnableAttractMode.Checked == true)
					{
						sEnableAttractMode = "EnableAttractMode";
				} else
					{
						sEnableAttractMode = "-EnableAttractMode";
				}
				if (cNewSkirmish.Checked == true)
					{
						sNewSkirmish = "NewSkirmish";
				} else
					{
						sNewSkirmish = "-NewSkirmish";
				}
				if (cNoHPBar.Checked == true)
					{
						sNoHPBar = "NoHPBar";
				} else
					{
						sNoHPBar = "-NoHPBar";
				}
				if (cSelectAllIgnoreWorking.Checked == true)
					{
						sSelectAllIgnoreWorking = "SelectAllIgnoreWorking";
				} else
					{
						sSelectAllIgnoreWorking = "-SelectAllIgnoreWorking";
				}
				if (cUseTestLeaders.Checked == true)
					{
						sUseTestLeaders = "UseTestLeaders";
				} else
					{
						sUseTestLeaders = "-UseTestLeaders";
				}
				if (cNoIntroCinematics.Checked == true)
					{
						sNoIntroCinematics = "NoIntroCinematics";
				} else
					{
						sNoIntroCinematics = "-NoIntroCinematics";
				}
				if (cPlayer1AI.Checked == true)
					{
						sPlayer1AI = "Player1AI";
				} else
					{
						sPlayer1AI = "-Player1AI";
				}
				if (cRenderSquadPlotter.Checked == true)
					{ 
						sRenderSquadPlotter = "RenderSquadPlotter";
				} else 
					{
						sRenderSquadPlotter = "-RenderSquadPlotter";
				}
				if (cLegacyIntro.Checked == true) 
					{
						sLegacyIntro = @"IntroCinematic=video\unratedLogos.bik";
						sLegacyIntro2 = @"//IntroCinematic2=video\MSGameStudio_Intro.bik";
				} else 
					{
						sLegacyIntro = @"IntroCinematic=video\343_Intro.bik";
						sLegacyIntro2 = @"IntroCinematic2=video\MSGameStudio_Intro.bik";
				}
				if (Convert.ToDouble(txtCameraFOV.Text) >= 0 && Convert.ToDouble(txtCameraFOV.Text) <= 1000)
					{
						sCameraFOV = (@"CameraFOV="+txtCameraFOV.Text);
				} else 
					{
						sCameraFOV = @"CameraFOV=44.9";
				} 
				if (Convert.ToDouble(txtCameraYaw.Text) >= 0 && Convert.ToDouble(txtCameraYaw.Text) <= 1000)
					{
						sCameraYaw = (@"CameraYaw="+txtCameraYaw.Text);
				} else 
					{
						sCameraYaw = @"CameraYaw=317.2";
				} 
				if (Convert.ToDouble(txtCameraPitchMax.Text) >= 0 && Convert.ToDouble(txtCameraPitchMax.Text) <= 1000)
					{
						sCameraPitchMax = (@"CameraPitchMax="+txtCameraPitchMax.Text);
				} else 
					{
						sCameraPitchMax = @"CameraPitchMax=54";
				} 
				if (Convert.ToDouble(txtCameraPitch.Text) >= 0 && Convert.ToDouble(txtCameraPitch.Text) <= 1000)
					{
						sCameraPitch = (@"CameraPitch="+txtCameraPitch.Text);
				} else 
					{
						sCameraPitch = @"CameraPitch=42";
				} 
				if (Convert.ToDouble(txtCameraPitchMin.Text) >= 0 && Convert.ToDouble(txtCameraPitchMin.Text) <= 1000)
					{
						sCameraPitchMin = (@"CameraPitchMin="+txtCameraPitchMin.Text);
				} else 
					{
						sCameraPitchMin = @"CameraPitchMin=34";
				} 
				if (Convert.ToDouble(txtCameraZoomMax.Text) >= 0 && Convert.ToDouble(txtCameraZoomMax.Text) <= 1000)
					{
						sCameraZoomMax = (@"CameraZoomMax="+txtCameraZoomMax.Text);
				} else 
					{
						sCameraZoomMax = @"CameraZoomMax=115";
				} 
				if (Convert.ToDouble(txtCameraZoom.Text) >= 0 && Convert.ToDouble(txtCameraZoom.Text) <= 1000)
					{
						sCameraZoom = (@"CameraZoom="+txtCameraZoom.Text);
				} else 
					{
						sCameraZoom = @"CameraZoom=85";
				}
				if (Convert.ToDouble(txtCameraZoomMin.Text) >= 0 && Convert.ToDouble(txtCameraZoomMin.Text) <= 1000)
					{
						sCameraZoomMin = (@"CameraZoomMin="+txtCameraZoomMin.Text);
				} else 
					{
						sCameraZoomMin = @"CameraZoomMin=60";
				}
				if (Convert.ToInt32(txtPhysicsMainThread.Text) >= 0 && Convert.ToInt32(txtPhysicsMainThread.Text) <= 64)
					{
						sPhysicsMainThread = (@"PhysicsMainThread="+txtPhysicsMainThread.Text);
				} else 
					{
						sPhysicsMainThread = @"PhysicsMainThread=2";
				} 
				if (Convert.ToInt32(txtNumPhysicsThreads.Text) >= 0 && Convert.ToInt32(txtNumPhysicsThreads.Text) <= 64)
					{
						sNumPhysicsThreads = (@"NumPhysicsThreads="+txtNumPhysicsThreads.Text);
				} else 
					{
						sNumPhysicsThreads = @"NumPhysicsThreads=1";
				} 
				
				// Create File
			try {
				using (StreamWriter sw = new StreamWriter("game.cfg")) {
						sw.WriteLine(@"// Blackandfans`s game.cfg");
						sw.WriteLine("");
						sw.WriteLine(@"// Custom settings");
						sw.WriteLine(@"// Camera");
						sw.WriteLine(sCameraFOV);
						sw.WriteLine(sCameraYaw);
						sw.WriteLine(sCameraPitchMax);
						sw.WriteLine(sCameraPitch);
						sw.WriteLine(sCameraPitchMin);
						sw.WriteLine(sCameraZoomMax);
						sw.WriteLine(sCameraZoom);
						sw.WriteLine(sCameraZoomMin);
						sw.WriteLine(sCameraLimit);
						sw.WriteLine(sLockCameraToWorld);
						sw.WriteLine("");
						sw.WriteLine(@"// UI");
						sw.WriteLine(sNoHPBar);
						sw.WriteLine(sFlashCovUI);
						sw.WriteLine(sFlashMinimap);
						sw.WriteLine(sFlashGameUI);
						sw.WriteLine(sSubtitles);
						sw.WriteLine("");
						sw.WriteLine(@"// Extras");
						sw.WriteLine(sPhysicsMainThread);
						sw.WriteLine(sNumPhysicsThreads);
						sw.WriteLine(sUseTestLeaders);
						sw.WriteLine(sLegacyIntro);
						sw.WriteLine(sLegacyIntro2);
						sw.WriteLine(sNoIntroCinematics);
						sw.WriteLine(sEnableAttractMode);
						sw.WriteLine(sPlayCinematicOnLoad);
						sw.WriteLine(sEnableCorpses);
						sw.WriteLine(sSelectAllIgnoreWorking);
						sw.WriteLine("");
						sw.WriteLine(@"// Debug");
						sw.WriteLine(sRenderSquadPlotter);
						sw.WriteLine(sNewSkirmish);
						sw.WriteLine(sPlayer1AI);
						sw.WriteLine("");
						sw.WriteLine(sremaining);
						sw.Close();
				}
			MessageBox.Show("Done");
			} catch (Exception error) {
				MessageBox.Show(Convert.ToString(error));
			} 
				
		// failed to set variables
			} catch {
				MessageBox.Show("There has been a issue with setting the flags");
			}
			
		}
		void BtnResetClick(object sender, EventArgs e)
		{
			this.txtCameraFOV.Text = "44.9";
			this.txtCameraYaw.Text = "317.2";
			this.txtCameraPitchMax.Text = "54";
			this.txtCameraPitch.Text = "42";
			this.txtCameraPitchMin.Text = "34";
			this.txtCameraZoomMax.Text = "115";
			this.txtCameraZoom.Text = "85";
			this.txtCameraZoomMin.Text = "60";
			this.txtPhysicsMainThread.Text = "1";
			this.txtNumPhysicsThreads.Text = "2";
			this.cLockCameraToWorld.Checked = true;
			this.cCameraLimits.Checked = true;
			this.cFlashCovUI.Checked = true;
			this.cFlashMinimap.Checked = true;
			this.cFlashGameUI.Checked = true;
			this.cEnableCorpses.Checked = true;
			this.cPlayCinematicOnLoad.Checked = true;
			this.cEnableAttractMode.Checked = true;
			this.cNewSkirmish.Checked = true;
			this.cNoHPBar.Checked = false;
			this.cSelectAllIgnoreWorking.Checked = false;
			this.cUseTestLeaders.Checked = false;
			this.cNoIntroCinematics.Checked = false;
			this.cLegacyIntro.Checked = false;
			this.cPlayer1AI.Checked = false;
			this.cRenderSquadPlotter.Checked = false;
		}
	}
}
