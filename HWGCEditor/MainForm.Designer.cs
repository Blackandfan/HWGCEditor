/*
 * Created by SharpDevelop.
 * User: black
 * Date: 16/03/2024
 * Time: 16:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace HWGCEditor
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.CheckBox cCameraLimits;
		private System.Windows.Forms.CheckBox cLockCameraToWorld;
		private System.Windows.Forms.TabControl tabs;
		private System.Windows.Forms.TabPage tabCamera;
		private System.Windows.Forms.TabPage tabUI;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtCameraFOV;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtCameraYaw;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCameraPitchMax;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCameraPitch;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtCameraPitchMin;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCameraZoomMax;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCameraZoom;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.TextBox txtCameraZoomMin;
		private System.Windows.Forms.CheckBox cFlashCovUI;
		private System.Windows.Forms.CheckBox cFlashMinimap;
		private System.Windows.Forms.CheckBox cFlashGameUI;
		private System.Windows.Forms.CheckBox cNoHPBar;
		private System.Windows.Forms.TabPage tabExtras;
		private System.Windows.Forms.CheckBox cEnableCorpses;
		private System.Windows.Forms.CheckBox cPlayCinematicOnLoad;
		private System.Windows.Forms.CheckBox cEnableAttractMode;
		private System.Windows.Forms.CheckBox cNoIntroCinematics;
		private System.Windows.Forms.CheckBox cLegacyIntro;
		private System.Windows.Forms.CheckBox cPlayer1AI;
		private System.Windows.Forms.TabPage tabDebug;
		private System.Windows.Forms.CheckBox cNewSkirmish;
		private System.Windows.Forms.CheckBox cRenderSquadPlotter;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtPhysicsMainThread;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtNumPhysicsThreads;
		private System.Windows.Forms.CheckBox cUseTestLeaders;
		private System.Windows.Forms.CheckBox cSelectAllIgnoreWorking;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.CheckBox cSubtitles;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnCreate = new System.Windows.Forms.Button();
			this.tabs = new System.Windows.Forms.TabControl();
			this.tabCamera = new System.Windows.Forms.TabPage();
			this.cLockCameraToWorld = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCameraFOV = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtCameraYaw = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCameraPitchMax = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCameraPitch = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCameraPitchMin = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCameraZoomMax = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCameraZoom = new System.Windows.Forms.TextBox();
			this.label = new System.Windows.Forms.Label();
			this.txtCameraZoomMin = new System.Windows.Forms.TextBox();
			this.cCameraLimits = new System.Windows.Forms.CheckBox();
			this.tabUI = new System.Windows.Forms.TabPage();
			this.cFlashCovUI = new System.Windows.Forms.CheckBox();
			this.cFlashMinimap = new System.Windows.Forms.CheckBox();
			this.cFlashGameUI = new System.Windows.Forms.CheckBox();
			this.cNoHPBar = new System.Windows.Forms.CheckBox();
			this.tabExtras = new System.Windows.Forms.TabPage();
			this.cSelectAllIgnoreWorking = new System.Windows.Forms.CheckBox();
			this.cUseTestLeaders = new System.Windows.Forms.CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtPhysicsMainThread = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtNumPhysicsThreads = new System.Windows.Forms.TextBox();
			this.cEnableCorpses = new System.Windows.Forms.CheckBox();
			this.cPlayCinematicOnLoad = new System.Windows.Forms.CheckBox();
			this.cEnableAttractMode = new System.Windows.Forms.CheckBox();
			this.cNoIntroCinematics = new System.Windows.Forms.CheckBox();
			this.cLegacyIntro = new System.Windows.Forms.CheckBox();
			this.tabDebug = new System.Windows.Forms.TabPage();
			this.cPlayer1AI = new System.Windows.Forms.CheckBox();
			this.cNewSkirmish = new System.Windows.Forms.CheckBox();
			this.cRenderSquadPlotter = new System.Windows.Forms.CheckBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.cSubtitles = new System.Windows.Forms.CheckBox();
			this.tabs.SuspendLayout();
			this.tabCamera.SuspendLayout();
			this.tabUI.SuspendLayout();
			this.tabExtras.SuspendLayout();
			this.tabDebug.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCreate
			// 
			this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnCreate.Location = new System.Drawing.Point(551, 311);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(105, 23);
			this.btnCreate.TabIndex = 0;
			this.btnCreate.Text = "Create game.cfg";
			this.btnCreate.UseVisualStyleBackColor = false;
			this.btnCreate.Click += new System.EventHandler(this.BtnCreateClick);
			// 
			// tabs
			// 
			this.tabs.Controls.Add(this.tabCamera);
			this.tabs.Controls.Add(this.tabUI);
			this.tabs.Controls.Add(this.tabExtras);
			this.tabs.Controls.Add(this.tabDebug);
			this.tabs.Location = new System.Drawing.Point(12, 12);
			this.tabs.Multiline = true;
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new System.Drawing.Size(533, 322);
			this.tabs.TabIndex = 11;
			// 
			// tabCamera
			// 
			this.tabCamera.Controls.Add(this.cLockCameraToWorld);
			this.tabCamera.Controls.Add(this.label6);
			this.tabCamera.Controls.Add(this.txtCameraFOV);
			this.tabCamera.Controls.Add(this.label7);
			this.tabCamera.Controls.Add(this.txtCameraYaw);
			this.tabCamera.Controls.Add(this.label3);
			this.tabCamera.Controls.Add(this.txtCameraPitchMax);
			this.tabCamera.Controls.Add(this.label4);
			this.tabCamera.Controls.Add(this.txtCameraPitch);
			this.tabCamera.Controls.Add(this.label5);
			this.tabCamera.Controls.Add(this.txtCameraPitchMin);
			this.tabCamera.Controls.Add(this.label2);
			this.tabCamera.Controls.Add(this.txtCameraZoomMax);
			this.tabCamera.Controls.Add(this.label1);
			this.tabCamera.Controls.Add(this.txtCameraZoom);
			this.tabCamera.Controls.Add(this.label);
			this.tabCamera.Controls.Add(this.txtCameraZoomMin);
			this.tabCamera.Controls.Add(this.cCameraLimits);
			this.tabCamera.Location = new System.Drawing.Point(4, 22);
			this.tabCamera.Name = "tabCamera";
			this.tabCamera.Padding = new System.Windows.Forms.Padding(3);
			this.tabCamera.Size = new System.Drawing.Size(525, 296);
			this.tabCamera.TabIndex = 0;
			this.tabCamera.Text = "Camera";
			this.tabCamera.UseVisualStyleBackColor = true;
			// 
			// cLockCameraToWorld
			// 
			this.cLockCameraToWorld.Checked = true;
			this.cLockCameraToWorld.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cLockCameraToWorld.Location = new System.Drawing.Point(6, 36);
			this.cLockCameraToWorld.Name = "cLockCameraToWorld";
			this.cLockCameraToWorld.Size = new System.Drawing.Size(135, 24);
			this.cLockCameraToWorld.TabIndex = 31;
			this.cLockCameraToWorld.Text = "LockCameraToWorld";
			this.cLockCameraToWorld.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(419, 195);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 30;
			this.label6.Text = "CameraFOV";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtCameraFOV
			// 
			this.txtCameraFOV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txtCameraFOV.Location = new System.Drawing.Point(378, 198);
			this.txtCameraFOV.Name = "txtCameraFOV";
			this.txtCameraFOV.Size = new System.Drawing.Size(35, 20);
			this.txtCameraFOV.TabIndex = 29;
			this.txtCameraFOV.Text = "44.9";
			this.txtCameraFOV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(419, 172);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 28;
			this.label7.Text = "CameraYaw";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtCameraYaw
			// 
			this.txtCameraYaw.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txtCameraYaw.Location = new System.Drawing.Point(378, 175);
			this.txtCameraYaw.Name = "txtCameraYaw";
			this.txtCameraYaw.Size = new System.Drawing.Size(35, 20);
			this.txtCameraYaw.TabIndex = 27;
			this.txtCameraYaw.Text = "317.2";
			this.txtCameraYaw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(419, 134);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 26;
			this.label3.Text = "CameraPitchMax";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtCameraPitchMax
			// 
			this.txtCameraPitchMax.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txtCameraPitchMax.Location = new System.Drawing.Point(378, 137);
			this.txtCameraPitchMax.Name = "txtCameraPitchMax";
			this.txtCameraPitchMax.Size = new System.Drawing.Size(35, 20);
			this.txtCameraPitchMax.TabIndex = 25;
			this.txtCameraPitchMax.Text = "54";
			this.txtCameraPitchMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(419, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 24;
			this.label4.Text = "CameraPitch";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtCameraPitch
			// 
			this.txtCameraPitch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txtCameraPitch.Location = new System.Drawing.Point(378, 114);
			this.txtCameraPitch.Name = "txtCameraPitch";
			this.txtCameraPitch.Size = new System.Drawing.Size(35, 20);
			this.txtCameraPitch.TabIndex = 23;
			this.txtCameraPitch.Text = "42";
			this.txtCameraPitch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(419, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 22;
			this.label5.Text = "CameraPitchMin";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtCameraPitchMin
			// 
			this.txtCameraPitchMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txtCameraPitchMin.Location = new System.Drawing.Point(378, 91);
			this.txtCameraPitchMin.Name = "txtCameraPitchMin";
			this.txtCameraPitchMin.Size = new System.Drawing.Size(35, 20);
			this.txtCameraPitchMin.TabIndex = 21;
			this.txtCameraPitchMin.Text = "34";
			this.txtCameraPitchMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(419, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 20;
			this.label2.Text = "CameraZoomMax";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtCameraZoomMax
			// 
			this.txtCameraZoomMax.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txtCameraZoomMax.Location = new System.Drawing.Point(378, 56);
			this.txtCameraZoomMax.Name = "txtCameraZoomMax";
			this.txtCameraZoomMax.Size = new System.Drawing.Size(35, 20);
			this.txtCameraZoomMax.TabIndex = 19;
			this.txtCameraZoomMax.Text = "115";
			this.txtCameraZoomMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(419, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 18;
			this.label1.Text = "CameraZoom";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtCameraZoom
			// 
			this.txtCameraZoom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txtCameraZoom.Location = new System.Drawing.Point(378, 33);
			this.txtCameraZoom.Name = "txtCameraZoom";
			this.txtCameraZoom.Size = new System.Drawing.Size(35, 20);
			this.txtCameraZoom.TabIndex = 17;
			this.txtCameraZoom.Text = "85";
			this.txtCameraZoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label
			// 
			this.label.Location = new System.Drawing.Point(419, 7);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(100, 23);
			this.label.TabIndex = 16;
			this.label.Text = "CameraZoomMin";
			this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtCameraZoomMin
			// 
			this.txtCameraZoomMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txtCameraZoomMin.Location = new System.Drawing.Point(378, 10);
			this.txtCameraZoomMin.Name = "txtCameraZoomMin";
			this.txtCameraZoomMin.Size = new System.Drawing.Size(35, 20);
			this.txtCameraZoomMin.TabIndex = 15;
			this.txtCameraZoomMin.Text = "60";
			this.txtCameraZoomMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cCameraLimits
			// 
			this.cCameraLimits.Checked = true;
			this.cCameraLimits.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cCameraLimits.Location = new System.Drawing.Point(6, 6);
			this.cCameraLimits.Name = "cCameraLimits";
			this.cCameraLimits.Size = new System.Drawing.Size(104, 24);
			this.cCameraLimits.TabIndex = 9;
			this.cCameraLimits.Text = "CameraLimits";
			this.cCameraLimits.UseVisualStyleBackColor = true;
			// 
			// tabUI
			// 
			this.tabUI.Controls.Add(this.cSubtitles);
			this.tabUI.Controls.Add(this.cFlashCovUI);
			this.tabUI.Controls.Add(this.cFlashMinimap);
			this.tabUI.Controls.Add(this.cFlashGameUI);
			this.tabUI.Controls.Add(this.cNoHPBar);
			this.tabUI.Location = new System.Drawing.Point(4, 22);
			this.tabUI.Name = "tabUI";
			this.tabUI.Padding = new System.Windows.Forms.Padding(3);
			this.tabUI.Size = new System.Drawing.Size(525, 296);
			this.tabUI.TabIndex = 1;
			this.tabUI.Text = "UI";
			this.tabUI.UseVisualStyleBackColor = true;
			// 
			// cFlashCovUI
			// 
			this.cFlashCovUI.Checked = true;
			this.cFlashCovUI.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cFlashCovUI.Location = new System.Drawing.Point(6, 96);
			this.cFlashCovUI.Name = "cFlashCovUI";
			this.cFlashCovUI.Size = new System.Drawing.Size(104, 24);
			this.cFlashCovUI.TabIndex = 19;
			this.cFlashCovUI.Text = "FlashCovUI";
			this.cFlashCovUI.UseVisualStyleBackColor = true;
			// 
			// cFlashMinimap
			// 
			this.cFlashMinimap.Checked = true;
			this.cFlashMinimap.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cFlashMinimap.Location = new System.Drawing.Point(6, 66);
			this.cFlashMinimap.Name = "cFlashMinimap";
			this.cFlashMinimap.Size = new System.Drawing.Size(104, 24);
			this.cFlashMinimap.TabIndex = 18;
			this.cFlashMinimap.Text = "FlashMinimap";
			this.cFlashMinimap.UseVisualStyleBackColor = true;
			// 
			// cFlashGameUI
			// 
			this.cFlashGameUI.Checked = true;
			this.cFlashGameUI.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cFlashGameUI.Location = new System.Drawing.Point(6, 36);
			this.cFlashGameUI.Name = "cFlashGameUI";
			this.cFlashGameUI.Size = new System.Drawing.Size(104, 24);
			this.cFlashGameUI.TabIndex = 17;
			this.cFlashGameUI.Text = "FlashGameUI";
			this.cFlashGameUI.UseVisualStyleBackColor = true;
			// 
			// cNoHPBar
			// 
			this.cNoHPBar.Location = new System.Drawing.Point(6, 6);
			this.cNoHPBar.Name = "cNoHPBar";
			this.cNoHPBar.Size = new System.Drawing.Size(104, 24);
			this.cNoHPBar.TabIndex = 16;
			this.cNoHPBar.Text = "NoHPBar";
			this.cNoHPBar.UseVisualStyleBackColor = true;
			// 
			// tabExtras
			// 
			this.tabExtras.Controls.Add(this.cSelectAllIgnoreWorking);
			this.tabExtras.Controls.Add(this.cUseTestLeaders);
			this.tabExtras.Controls.Add(this.label8);
			this.tabExtras.Controls.Add(this.txtPhysicsMainThread);
			this.tabExtras.Controls.Add(this.label9);
			this.tabExtras.Controls.Add(this.txtNumPhysicsThreads);
			this.tabExtras.Controls.Add(this.cEnableCorpses);
			this.tabExtras.Controls.Add(this.cPlayCinematicOnLoad);
			this.tabExtras.Controls.Add(this.cEnableAttractMode);
			this.tabExtras.Controls.Add(this.cNoIntroCinematics);
			this.tabExtras.Controls.Add(this.cLegacyIntro);
			this.tabExtras.Location = new System.Drawing.Point(4, 22);
			this.tabExtras.Name = "tabExtras";
			this.tabExtras.Padding = new System.Windows.Forms.Padding(3);
			this.tabExtras.Size = new System.Drawing.Size(525, 296);
			this.tabExtras.TabIndex = 4;
			this.tabExtras.Text = "Extras";
			this.tabExtras.UseVisualStyleBackColor = true;
			// 
			// cSelectAllIgnoreWorking
			// 
			this.cSelectAllIgnoreWorking.Location = new System.Drawing.Point(6, 186);
			this.cSelectAllIgnoreWorking.Name = "cSelectAllIgnoreWorking";
			this.cSelectAllIgnoreWorking.Size = new System.Drawing.Size(147, 24);
			this.cSelectAllIgnoreWorking.TabIndex = 26;
			this.cSelectAllIgnoreWorking.Text = "SelectAllIgnoreWorking";
			this.cSelectAllIgnoreWorking.UseVisualStyleBackColor = true;
			// 
			// cUseTestLeaders
			// 
			this.cUseTestLeaders.Location = new System.Drawing.Point(6, 6);
			this.cUseTestLeaders.Name = "cUseTestLeaders";
			this.cUseTestLeaders.Size = new System.Drawing.Size(104, 24);
			this.cUseTestLeaders.TabIndex = 25;
			this.cUseTestLeaders.Text = "UseTestLeaders";
			this.cUseTestLeaders.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(409, 33);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 24;
			this.label8.Text = "PhysicsMainThread";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtPhysicsMainThread
			// 
			this.txtPhysicsMainThread.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txtPhysicsMainThread.Location = new System.Drawing.Point(379, 36);
			this.txtPhysicsMainThread.Name = "txtPhysicsMainThread";
			this.txtPhysicsMainThread.Size = new System.Drawing.Size(24, 20);
			this.txtPhysicsMainThread.TabIndex = 23;
			this.txtPhysicsMainThread.Text = "1";
			this.txtPhysicsMainThread.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(409, 10);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(110, 23);
			this.label9.TabIndex = 22;
			this.label9.Text = "NumPhysicsThreads";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtNumPhysicsThreads
			// 
			this.txtNumPhysicsThreads.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txtNumPhysicsThreads.Location = new System.Drawing.Point(379, 13);
			this.txtNumPhysicsThreads.Name = "txtNumPhysicsThreads";
			this.txtNumPhysicsThreads.Size = new System.Drawing.Size(24, 20);
			this.txtNumPhysicsThreads.TabIndex = 21;
			this.txtNumPhysicsThreads.Text = "2";
			this.txtNumPhysicsThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cEnableCorpses
			// 
			this.cEnableCorpses.Checked = true;
			this.cEnableCorpses.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cEnableCorpses.Location = new System.Drawing.Point(6, 156);
			this.cEnableCorpses.Name = "cEnableCorpses";
			this.cEnableCorpses.Size = new System.Drawing.Size(104, 24);
			this.cEnableCorpses.TabIndex = 20;
			this.cEnableCorpses.Text = "EnableCorpses";
			this.cEnableCorpses.UseVisualStyleBackColor = true;
			// 
			// cPlayCinematicOnLoad
			// 
			this.cPlayCinematicOnLoad.Checked = true;
			this.cPlayCinematicOnLoad.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cPlayCinematicOnLoad.Location = new System.Drawing.Point(6, 126);
			this.cPlayCinematicOnLoad.Name = "cPlayCinematicOnLoad";
			this.cPlayCinematicOnLoad.Size = new System.Drawing.Size(132, 24);
			this.cPlayCinematicOnLoad.TabIndex = 19;
			this.cPlayCinematicOnLoad.Text = "PlayCinematicOnLoad";
			this.cPlayCinematicOnLoad.UseVisualStyleBackColor = true;
			// 
			// cEnableAttractMode
			// 
			this.cEnableAttractMode.Checked = true;
			this.cEnableAttractMode.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cEnableAttractMode.Location = new System.Drawing.Point(6, 96);
			this.cEnableAttractMode.Name = "cEnableAttractMode";
			this.cEnableAttractMode.Size = new System.Drawing.Size(132, 24);
			this.cEnableAttractMode.TabIndex = 18;
			this.cEnableAttractMode.Text = "EnableAttractMode";
			this.cEnableAttractMode.UseVisualStyleBackColor = true;
			// 
			// cNoIntroCinematics
			// 
			this.cNoIntroCinematics.Location = new System.Drawing.Point(6, 66);
			this.cNoIntroCinematics.Name = "cNoIntroCinematics";
			this.cNoIntroCinematics.Size = new System.Drawing.Size(114, 24);
			this.cNoIntroCinematics.TabIndex = 17;
			this.cNoIntroCinematics.Text = "NoIntroCinematics";
			this.cNoIntroCinematics.UseVisualStyleBackColor = true;
			// 
			// cLegacyIntro
			// 
			this.cLegacyIntro.Location = new System.Drawing.Point(6, 36);
			this.cLegacyIntro.Name = "cLegacyIntro";
			this.cLegacyIntro.Size = new System.Drawing.Size(104, 24);
			this.cLegacyIntro.TabIndex = 16;
			this.cLegacyIntro.Text = "Legacy Intro";
			this.cLegacyIntro.UseVisualStyleBackColor = true;
			// 
			// tabDebug
			// 
			this.tabDebug.Controls.Add(this.cPlayer1AI);
			this.tabDebug.Controls.Add(this.cNewSkirmish);
			this.tabDebug.Controls.Add(this.cRenderSquadPlotter);
			this.tabDebug.Location = new System.Drawing.Point(4, 22);
			this.tabDebug.Name = "tabDebug";
			this.tabDebug.Padding = new System.Windows.Forms.Padding(3);
			this.tabDebug.Size = new System.Drawing.Size(525, 296);
			this.tabDebug.TabIndex = 3;
			this.tabDebug.Text = "Debug";
			this.tabDebug.UseVisualStyleBackColor = true;
			// 
			// cPlayer1AI
			// 
			this.cPlayer1AI.Location = new System.Drawing.Point(6, 66);
			this.cPlayer1AI.Name = "cPlayer1AI";
			this.cPlayer1AI.Size = new System.Drawing.Size(104, 24);
			this.cPlayer1AI.TabIndex = 18;
			this.cPlayer1AI.Text = "Player1AI";
			this.cPlayer1AI.UseVisualStyleBackColor = true;
			// 
			// cNewSkirmish
			// 
			this.cNewSkirmish.Checked = true;
			this.cNewSkirmish.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cNewSkirmish.Location = new System.Drawing.Point(6, 36);
			this.cNewSkirmish.Name = "cNewSkirmish";
			this.cNewSkirmish.Size = new System.Drawing.Size(104, 24);
			this.cNewSkirmish.TabIndex = 16;
			this.cNewSkirmish.Text = "NewSkirmish";
			this.cNewSkirmish.UseVisualStyleBackColor = true;
			// 
			// cRenderSquadPlotter
			// 
			this.cRenderSquadPlotter.Location = new System.Drawing.Point(6, 6);
			this.cRenderSquadPlotter.Name = "cRenderSquadPlotter";
			this.cRenderSquadPlotter.Size = new System.Drawing.Size(129, 24);
			this.cRenderSquadPlotter.TabIndex = 15;
			this.cRenderSquadPlotter.Text = "RenderSquadPlotter";
			this.cRenderSquadPlotter.UseVisualStyleBackColor = true;
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(609, 284);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(47, 21);
			this.btnReset.TabIndex = 12;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// cSubtitles
			// 
			this.cSubtitles.Checked = true;
			this.cSubtitles.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cSubtitles.Location = new System.Drawing.Point(6, 126);
			this.cSubtitles.Name = "cSubtitles";
			this.cSubtitles.Size = new System.Drawing.Size(104, 24);
			this.cSubtitles.TabIndex = 20;
			this.cSubtitles.Text = "SubTitles";
			this.cSubtitles.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(668, 346);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.tabs);
			this.Controls.Add(this.btnCreate);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "HWGCEditor";
			this.tabs.ResumeLayout(false);
			this.tabCamera.ResumeLayout(false);
			this.tabCamera.PerformLayout();
			this.tabUI.ResumeLayout(false);
			this.tabExtras.ResumeLayout(false);
			this.tabExtras.PerformLayout();
			this.tabDebug.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
