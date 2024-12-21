using System.Drawing;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace SHR_HideSetting
{

    partial class Form1 
    {

        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.shadow_denoiser = new MaterialSkin.Controls.MaterialSlider();
            this.motion_blur = new MaterialSkin.Controls.MaterialSlider();
            this.blum_quality = new MaterialSkin.Controls.MaterialSlider();
            this.aa_quality = new MaterialSkin.Controls.MaterialSlider();
            this.dof_level = new MaterialSkin.Controls.MaterialSlider();
            this.dlss_denoizer = new MaterialSkin.Controls.MaterialSlider();
            this.bileteral_filter = new MaterialSkin.Controls.MaterialSlider();
            this.space_screen_recon = new MaterialSkin.Controls.MaterialSlider();
            this.temporal_reflaction = new MaterialSkin.Controls.MaterialSlider();
            this.distortion_level = new MaterialSkin.Controls.MaterialSlider();
            this.vignette_quality = new MaterialSkin.Controls.MaterialSlider();
            this.scene_color_fringe_max = new MaterialSkin.Controls.MaterialSlider();
            this.color_fringe_quality = new MaterialSkin.Controls.MaterialSlider();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.disable_distortion = new MaterialSkin.Controls.MaterialSwitch();
            this.enable_fog = new MaterialSkin.Controls.MaterialSwitch();
            this.vol_fog = new MaterialSkin.Controls.MaterialSwitch();
            this.enable_bokeh = new MaterialSkin.Controls.MaterialSwitch();
            this.enable_vrs = new MaterialSkin.Controls.MaterialSwitch();
            this.fsr3_frames = new MaterialSkin.Controls.MaterialSwitch();
            this.persets_combo = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.delete_mod_button = new System.Windows.Forms.Button();
            this.dist_level_cb = new System.Windows.Forms.CheckBox();
            this.motion_blur_cb = new System.Windows.Forms.CheckBox();
            this.bloom_quality_cb = new System.Windows.Forms.CheckBox();
            this.post_process_cb = new System.Windows.Forms.CheckBox();
            this.dof_cb = new System.Windows.Forms.CheckBox();
            this.shadow_denoiser_cb = new System.Windows.Forms.CheckBox();
            this.bokeh_switch_cb = new System.Windows.Forms.CheckBox();
            this.fog_swith_cb = new System.Windows.Forms.CheckBox();
            this.reflection_cb = new System.Windows.Forms.CheckBox();
            this.ssr_cb = new System.Windows.Forms.CheckBox();
            this.bileteral_filter_cb = new System.Windows.Forms.CheckBox();
            this.dlss_denoizer_cb = new System.Windows.Forms.CheckBox();
            this.distorsion_switch_cb = new System.Windows.Forms.CheckBox();
            this.vol_fog_cb = new System.Windows.Forms.CheckBox();
            this.vrs_cb = new System.Windows.Forms.CheckBox();
            this.fsr3_cb = new System.Windows.Forms.CheckBox();
            this.cfm_cb = new System.Windows.Forms.CheckBox();
            this.cfq_cb = new System.Windows.Forms.CheckBox();
            this.vignette_cb = new System.Windows.Forms.CheckBox();
            this.depth_blur_cb = new System.Windows.Forms.CheckBox();
            this.depth_blur_scale = new MaterialSkin.Controls.MaterialSlider();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(288, 349);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enable Fog";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(287, 314);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Disable Distortion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(10, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Distortion Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(10, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Motion Blure Quality";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(10, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bloom Quality";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(10, 237);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Post Process AA Quality";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(10, 312);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Depth of Field Level";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(288, 419);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Enable Bokeh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(270, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "DLLS Denoizer";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(270, 87);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Bilateral Filter";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(270, 162);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(232, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Screen Space Reconstruction";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(270, 237);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(216, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Temporal Reflection Quality";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(10, 387);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Shadow Denoiser Level";
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cancel_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancel_button.Location = new System.Drawing.Point(315, 485);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(90, 30);
            this.cancel_button.TabIndex = 13;
            this.cancel_button.Text = "CANCEL";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_settings);
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.save_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.save_button.Location = new System.Drawing.Point(420, 485);
            this.save_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(90, 30);
            this.save_button.TabIndex = 14;
            this.save_button.Text = "SAVE";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.apply_settings);
            // 
            // shadow_denoiser
            // 
            this.shadow_denoiser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.shadow_denoiser.Depth = 0;
            this.shadow_denoiser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.shadow_denoiser.Location = new System.Drawing.Point(28, 405);
            this.shadow_denoiser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shadow_denoiser.MouseState = MaterialSkin.MouseState.HOVER;
            this.shadow_denoiser.Name = "shadow_denoiser";
            this.shadow_denoiser.Size = new System.Drawing.Size(220, 40);
            this.shadow_denoiser.TabIndex = 30;
            this.shadow_denoiser.Text = "";
            // 
            // motion_blur
            // 
            this.motion_blur.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.motion_blur.Depth = 0;
            this.motion_blur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.motion_blur.Location = new System.Drawing.Point(28, 110);
            this.motion_blur.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.motion_blur.MouseState = MaterialSkin.MouseState.HOVER;
            this.motion_blur.Name = "motion_blur";
            this.motion_blur.Size = new System.Drawing.Size(220, 40);
            this.motion_blur.TabIndex = 31;
            this.motion_blur.Text = "";
            // 
            // blum_quality
            // 
            this.blum_quality.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.blum_quality.Depth = 0;
            this.blum_quality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.blum_quality.Location = new System.Drawing.Point(28, 185);
            this.blum_quality.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.blum_quality.MouseState = MaterialSkin.MouseState.HOVER;
            this.blum_quality.Name = "blum_quality";
            this.blum_quality.Size = new System.Drawing.Size(220, 40);
            this.blum_quality.TabIndex = 32;
            this.blum_quality.Text = "";
            // 
            // aa_quality
            // 
            this.aa_quality.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.aa_quality.Depth = 0;
            this.aa_quality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.aa_quality.Location = new System.Drawing.Point(28, 260);
            this.aa_quality.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.aa_quality.MouseState = MaterialSkin.MouseState.HOVER;
            this.aa_quality.Name = "aa_quality";
            this.aa_quality.Size = new System.Drawing.Size(220, 40);
            this.aa_quality.TabIndex = 33;
            this.aa_quality.Text = "";
            // 
            // dof_level
            // 
            this.dof_level.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dof_level.Depth = 0;
            this.dof_level.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dof_level.Location = new System.Drawing.Point(28, 335);
            this.dof_level.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dof_level.MouseState = MaterialSkin.MouseState.HOVER;
            this.dof_level.Name = "dof_level";
            this.dof_level.Size = new System.Drawing.Size(220, 40);
            this.dof_level.TabIndex = 34;
            this.dof_level.Text = "";
            // 
            // dlss_denoizer
            // 
            this.dlss_denoizer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dlss_denoizer.Depth = 0;
            this.dlss_denoizer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dlss_denoizer.Location = new System.Drawing.Point(292, 30);
            this.dlss_denoizer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dlss_denoizer.MouseState = MaterialSkin.MouseState.HOVER;
            this.dlss_denoizer.Name = "dlss_denoizer";
            this.dlss_denoizer.Size = new System.Drawing.Size(220, 40);
            this.dlss_denoizer.TabIndex = 35;
            this.dlss_denoizer.Text = "";
            // 
            // bileteral_filter
            // 
            this.bileteral_filter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bileteral_filter.Depth = 0;
            this.bileteral_filter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bileteral_filter.Location = new System.Drawing.Point(292, 110);
            this.bileteral_filter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bileteral_filter.MouseState = MaterialSkin.MouseState.HOVER;
            this.bileteral_filter.Name = "bileteral_filter";
            this.bileteral_filter.Size = new System.Drawing.Size(220, 40);
            this.bileteral_filter.TabIndex = 36;
            this.bileteral_filter.Text = "";
            // 
            // space_screen_recon
            // 
            this.space_screen_recon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.space_screen_recon.Depth = 0;
            this.space_screen_recon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.space_screen_recon.Location = new System.Drawing.Point(292, 185);
            this.space_screen_recon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.space_screen_recon.MouseState = MaterialSkin.MouseState.HOVER;
            this.space_screen_recon.Name = "space_screen_recon";
            this.space_screen_recon.Size = new System.Drawing.Size(220, 40);
            this.space_screen_recon.TabIndex = 37;
            this.space_screen_recon.Text = "";
            // 
            // temporal_reflaction
            // 
            this.temporal_reflaction.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.temporal_reflaction.Depth = 0;
            this.temporal_reflaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.temporal_reflaction.Location = new System.Drawing.Point(292, 260);
            this.temporal_reflaction.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.temporal_reflaction.MouseState = MaterialSkin.MouseState.HOVER;
            this.temporal_reflaction.Name = "temporal_reflaction";
            this.temporal_reflaction.Size = new System.Drawing.Size(220, 40);
            this.temporal_reflaction.TabIndex = 38;
            this.temporal_reflaction.Text = "";
            // 
            // distortion_level
            // 
            this.distortion_level.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.distortion_level.Depth = 0;
            this.distortion_level.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.distortion_level.Location = new System.Drawing.Point(28, 30);
            this.distortion_level.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.distortion_level.MouseState = MaterialSkin.MouseState.HOVER;
            this.distortion_level.Name = "distortion_level";
            this.distortion_level.Size = new System.Drawing.Size(220, 40);
            this.distortion_level.TabIndex = 39;
            this.distortion_level.Text = "";
            // 
            // vignette_quality
            // 
            this.vignette_quality.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vignette_quality.Depth = 0;
            this.vignette_quality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.vignette_quality.Location = new System.Drawing.Point(567, 30);
            this.vignette_quality.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.vignette_quality.MouseState = MaterialSkin.MouseState.HOVER;
            this.vignette_quality.Name = "vignette_quality";
            this.vignette_quality.Size = new System.Drawing.Size(220, 40);
            this.vignette_quality.TabIndex = 51;
            this.vignette_quality.Text = "";
            // 
            // scene_color_fringe_max
            // 
            this.scene_color_fringe_max.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scene_color_fringe_max.Depth = 0;
            this.scene_color_fringe_max.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.scene_color_fringe_max.Location = new System.Drawing.Point(567, 185);
            this.scene_color_fringe_max.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.scene_color_fringe_max.MouseState = MaterialSkin.MouseState.HOVER;
            this.scene_color_fringe_max.Name = "scene_color_fringe_max";
            this.scene_color_fringe_max.Size = new System.Drawing.Size(220, 40);
            this.scene_color_fringe_max.TabIndex = 48;
            this.scene_color_fringe_max.Text = "";
            // 
            // color_fringe_quality
            // 
            this.color_fringe_quality.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.color_fringe_quality.Depth = 0;
            this.color_fringe_quality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.color_fringe_quality.Location = new System.Drawing.Point(567, 110);
            this.color_fringe_quality.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.color_fringe_quality.MouseState = MaterialSkin.MouseState.HOVER;
            this.color_fringe_quality.Name = "color_fringe_quality";
            this.color_fringe_quality.Size = new System.Drawing.Size(220, 40);
            this.color_fringe_quality.TabIndex = 47;
            this.color_fringe_quality.Text = "";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(549, 162);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(308, 20);
            this.label17.TabIndex = 42;
            this.label17.Text = "Color Fringe Max (chromatic aberration)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(549, 87);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(329, 20);
            this.label18.TabIndex = 41;
            this.label18.Text = "Color Fringe Quality (chromatic aberration)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(549, 12);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(127, 20);
            this.label19.TabIndex = 40;
            this.label19.Text = "Vignette Quality";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(567, 314);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(231, 20);
            this.label14.TabIndex = 60;
            this.label14.Text = "Enable Variable Rate Shading";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(567, 349);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(252, 20);
            this.label21.TabIndex = 55;
            this.label21.Text = "Enable FSR 3 Frame Generation";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(288, 384);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(178, 20);
            this.label22.TabIndex = 54;
            this.label22.Text = "Enable Volumetric Fog";
            // 
            // disable_distortion
            // 
            this.disable_distortion.AutoSize = true;
            this.disable_distortion.Depth = 0;
            this.disable_distortion.Location = new System.Drawing.Point(470, 305);
            this.disable_distortion.Margin = new System.Windows.Forms.Padding(0);
            this.disable_distortion.MouseLocation = new System.Drawing.Point(-1, -1);
            this.disable_distortion.MouseState = MaterialSkin.MouseState.HOVER;
            this.disable_distortion.Name = "disable_distortion";
            this.disable_distortion.Ripple = true;
            this.disable_distortion.Size = new System.Drawing.Size(58, 37);
            this.disable_distortion.TabIndex = 62;
            this.disable_distortion.UseVisualStyleBackColor = true;
            // 
            // enable_fog
            // 
            this.enable_fog.AutoSize = true;
            this.enable_fog.Depth = 0;
            this.enable_fog.Location = new System.Drawing.Point(470, 340);
            this.enable_fog.Margin = new System.Windows.Forms.Padding(0);
            this.enable_fog.MouseLocation = new System.Drawing.Point(-1, -1);
            this.enable_fog.MouseState = MaterialSkin.MouseState.HOVER;
            this.enable_fog.Name = "enable_fog";
            this.enable_fog.Ripple = true;
            this.enable_fog.Size = new System.Drawing.Size(58, 37);
            this.enable_fog.TabIndex = 63;
            this.enable_fog.UseVisualStyleBackColor = true;
            // 
            // vol_fog
            // 
            this.vol_fog.AutoSize = true;
            this.vol_fog.Depth = 0;
            this.vol_fog.Location = new System.Drawing.Point(470, 375);
            this.vol_fog.Margin = new System.Windows.Forms.Padding(0);
            this.vol_fog.MouseLocation = new System.Drawing.Point(-1, -1);
            this.vol_fog.MouseState = MaterialSkin.MouseState.HOVER;
            this.vol_fog.Name = "vol_fog";
            this.vol_fog.Ripple = true;
            this.vol_fog.Size = new System.Drawing.Size(58, 37);
            this.vol_fog.TabIndex = 64;
            this.vol_fog.UseVisualStyleBackColor = true;
            // 
            // enable_bokeh
            // 
            this.enable_bokeh.AutoSize = true;
            this.enable_bokeh.Depth = 0;
            this.enable_bokeh.Location = new System.Drawing.Point(470, 405);
            this.enable_bokeh.Margin = new System.Windows.Forms.Padding(0);
            this.enable_bokeh.MouseLocation = new System.Drawing.Point(-1, -1);
            this.enable_bokeh.MouseState = MaterialSkin.MouseState.HOVER;
            this.enable_bokeh.Name = "enable_bokeh";
            this.enable_bokeh.Ripple = true;
            this.enable_bokeh.Size = new System.Drawing.Size(58, 37);
            this.enable_bokeh.TabIndex = 65;
            this.enable_bokeh.UseVisualStyleBackColor = true;
            // 
            // enable_vrs
            // 
            this.enable_vrs.AutoSize = true;
            this.enable_vrs.Depth = 0;
            this.enable_vrs.Location = new System.Drawing.Point(752, 305);
            this.enable_vrs.Margin = new System.Windows.Forms.Padding(0);
            this.enable_vrs.MouseLocation = new System.Drawing.Point(-1, -1);
            this.enable_vrs.MouseState = MaterialSkin.MouseState.HOVER;
            this.enable_vrs.Name = "enable_vrs";
            this.enable_vrs.Ripple = true;
            this.enable_vrs.Size = new System.Drawing.Size(58, 37);
            this.enable_vrs.TabIndex = 66;
            this.enable_vrs.UseVisualStyleBackColor = true;
            // 
            // fsr3_frames
            // 
            this.fsr3_frames.AutoSize = true;
            this.fsr3_frames.Depth = 0;
            this.fsr3_frames.Location = new System.Drawing.Point(752, 340);
            this.fsr3_frames.Margin = new System.Windows.Forms.Padding(0);
            this.fsr3_frames.MouseLocation = new System.Drawing.Point(-1, -1);
            this.fsr3_frames.MouseState = MaterialSkin.MouseState.HOVER;
            this.fsr3_frames.Name = "fsr3_frames";
            this.fsr3_frames.Ripple = true;
            this.fsr3_frames.Size = new System.Drawing.Size(58, 37);
            this.fsr3_frames.TabIndex = 67;
            this.fsr3_frames.UseVisualStyleBackColor = true;
            // 
            // persets_combo
            // 
            this.persets_combo.FormattingEnabled = true;
            this.persets_combo.Location = new System.Drawing.Point(632, 390);
            this.persets_combo.Name = "persets_combo";
            this.persets_combo.Size = new System.Drawing.Size(159, 28);
            this.persets_combo.TabIndex = 69;
            this.persets_combo.SelectedIndexChanged += new System.EventHandler(this.persets_combo_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(555, 395);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 20);
            this.label15.TabIndex = 70;
            this.label15.Text = "Presets";
            // 
            // delete_mod_button
            // 
            this.delete_mod_button.Location = new System.Drawing.Point(685, 485);
            this.delete_mod_button.Name = "delete_mod_button";
            this.delete_mod_button.Size = new System.Drawing.Size(115, 30);
            this.delete_mod_button.TabIndex = 71;
            this.delete_mod_button.Text = "Delete mod";
            this.delete_mod_button.UseVisualStyleBackColor = true;
            this.delete_mod_button.Click += new System.EventHandler(this.delete_mod_button_Click);
            // 
            // dist_level_cb
            // 
            this.dist_level_cb.AutoSize = true;
            this.dist_level_cb.Location = new System.Drawing.Point(13, 45);
            this.dist_level_cb.Name = "dist_level_cb";
            this.dist_level_cb.Size = new System.Drawing.Size(18, 17);
            this.dist_level_cb.TabIndex = 72;
            this.dist_level_cb.UseVisualStyleBackColor = true;
            // 
            // motion_blur_cb
            // 
            this.motion_blur_cb.AutoSize = true;
            this.motion_blur_cb.Location = new System.Drawing.Point(13, 125);
            this.motion_blur_cb.Name = "motion_blur_cb";
            this.motion_blur_cb.Size = new System.Drawing.Size(18, 17);
            this.motion_blur_cb.TabIndex = 73;
            this.motion_blur_cb.UseVisualStyleBackColor = true;
            // 
            // bloom_quality_cb
            // 
            this.bloom_quality_cb.AutoSize = true;
            this.bloom_quality_cb.Location = new System.Drawing.Point(13, 200);
            this.bloom_quality_cb.Name = "bloom_quality_cb";
            this.bloom_quality_cb.Size = new System.Drawing.Size(18, 17);
            this.bloom_quality_cb.TabIndex = 74;
            this.bloom_quality_cb.UseVisualStyleBackColor = true;
            // 
            // post_process_cb
            // 
            this.post_process_cb.AutoSize = true;
            this.post_process_cb.Location = new System.Drawing.Point(13, 275);
            this.post_process_cb.Name = "post_process_cb";
            this.post_process_cb.Size = new System.Drawing.Size(18, 17);
            this.post_process_cb.TabIndex = 75;
            this.post_process_cb.UseVisualStyleBackColor = true;
            // 
            // dof_cb
            // 
            this.dof_cb.AutoSize = true;
            this.dof_cb.Location = new System.Drawing.Point(13, 350);
            this.dof_cb.Name = "dof_cb";
            this.dof_cb.Size = new System.Drawing.Size(18, 17);
            this.dof_cb.TabIndex = 76;
            this.dof_cb.UseVisualStyleBackColor = true;
            // 
            // shadow_denoiser_cb
            // 
            this.shadow_denoiser_cb.AutoSize = true;
            this.shadow_denoiser_cb.Location = new System.Drawing.Point(13, 420);
            this.shadow_denoiser_cb.Name = "shadow_denoiser_cb";
            this.shadow_denoiser_cb.Size = new System.Drawing.Size(18, 17);
            this.shadow_denoiser_cb.TabIndex = 77;
            this.shadow_denoiser_cb.UseVisualStyleBackColor = true;
            // 
            // bokeh_switch_cb
            // 
            this.bokeh_switch_cb.AutoSize = true;
            this.bokeh_switch_cb.Location = new System.Drawing.Point(273, 420);
            this.bokeh_switch_cb.Name = "bokeh_switch_cb";
            this.bokeh_switch_cb.Size = new System.Drawing.Size(18, 17);
            this.bokeh_switch_cb.TabIndex = 83;
            this.bokeh_switch_cb.UseVisualStyleBackColor = true;
            // 
            // fog_swith_cb
            // 
            this.fog_swith_cb.AutoSize = true;
            this.fog_swith_cb.Location = new System.Drawing.Point(273, 350);
            this.fog_swith_cb.Name = "fog_swith_cb";
            this.fog_swith_cb.Size = new System.Drawing.Size(18, 17);
            this.fog_swith_cb.TabIndex = 82;
            this.fog_swith_cb.UseVisualStyleBackColor = true;
            // 
            // reflection_cb
            // 
            this.reflection_cb.AutoSize = true;
            this.reflection_cb.Location = new System.Drawing.Point(273, 275);
            this.reflection_cb.Name = "reflection_cb";
            this.reflection_cb.Size = new System.Drawing.Size(18, 17);
            this.reflection_cb.TabIndex = 81;
            this.reflection_cb.UseVisualStyleBackColor = true;
            // 
            // ssr_cb
            // 
            this.ssr_cb.AutoSize = true;
            this.ssr_cb.Location = new System.Drawing.Point(273, 200);
            this.ssr_cb.Name = "ssr_cb";
            this.ssr_cb.Size = new System.Drawing.Size(18, 17);
            this.ssr_cb.TabIndex = 80;
            this.ssr_cb.UseVisualStyleBackColor = true;
            // 
            // bileteral_filter_cb
            // 
            this.bileteral_filter_cb.AutoSize = true;
            this.bileteral_filter_cb.Location = new System.Drawing.Point(273, 125);
            this.bileteral_filter_cb.Name = "bileteral_filter_cb";
            this.bileteral_filter_cb.Size = new System.Drawing.Size(18, 17);
            this.bileteral_filter_cb.TabIndex = 79;
            this.bileteral_filter_cb.UseVisualStyleBackColor = true;
            // 
            // dlss_denoizer_cb
            // 
            this.dlss_denoizer_cb.AutoSize = true;
            this.dlss_denoizer_cb.Location = new System.Drawing.Point(273, 45);
            this.dlss_denoizer_cb.Name = "dlss_denoizer_cb";
            this.dlss_denoizer_cb.Size = new System.Drawing.Size(18, 17);
            this.dlss_denoizer_cb.TabIndex = 78;
            this.dlss_denoizer_cb.UseVisualStyleBackColor = true;
            // 
            // distorsion_switch_cb
            // 
            this.distorsion_switch_cb.AutoSize = true;
            this.distorsion_switch_cb.Location = new System.Drawing.Point(273, 315);
            this.distorsion_switch_cb.Name = "distorsion_switch_cb";
            this.distorsion_switch_cb.Size = new System.Drawing.Size(18, 17);
            this.distorsion_switch_cb.TabIndex = 84;
            this.distorsion_switch_cb.UseVisualStyleBackColor = true;
            // 
            // vol_fog_cb
            // 
            this.vol_fog_cb.AutoSize = true;
            this.vol_fog_cb.Location = new System.Drawing.Point(273, 385);
            this.vol_fog_cb.Name = "vol_fog_cb";
            this.vol_fog_cb.Size = new System.Drawing.Size(18, 17);
            this.vol_fog_cb.TabIndex = 85;
            this.vol_fog_cb.UseVisualStyleBackColor = true;
            // 
            // vrs_cb
            // 
            this.vrs_cb.AutoSize = true;
            this.vrs_cb.Location = new System.Drawing.Point(552, 315);
            this.vrs_cb.Name = "vrs_cb";
            this.vrs_cb.Size = new System.Drawing.Size(18, 17);
            this.vrs_cb.TabIndex = 91;
            this.vrs_cb.UseVisualStyleBackColor = true;
            // 
            // fsr3_cb
            // 
            this.fsr3_cb.AutoSize = true;
            this.fsr3_cb.Location = new System.Drawing.Point(552, 350);
            this.fsr3_cb.Name = "fsr3_cb";
            this.fsr3_cb.Size = new System.Drawing.Size(18, 17);
            this.fsr3_cb.TabIndex = 89;
            this.fsr3_cb.UseVisualStyleBackColor = true;
            // 
            // cfm_cb
            // 
            this.cfm_cb.AutoSize = true;
            this.cfm_cb.Location = new System.Drawing.Point(552, 198);
            this.cfm_cb.Name = "cfm_cb";
            this.cfm_cb.Size = new System.Drawing.Size(18, 17);
            this.cfm_cb.TabIndex = 88;
            this.cfm_cb.UseVisualStyleBackColor = true;
            // 
            // cfq_cb
            // 
            this.cfq_cb.AutoSize = true;
            this.cfq_cb.Location = new System.Drawing.Point(552, 123);
            this.cfq_cb.Name = "cfq_cb";
            this.cfq_cb.Size = new System.Drawing.Size(18, 17);
            this.cfq_cb.TabIndex = 87;
            this.cfq_cb.UseVisualStyleBackColor = true;
            // 
            // vignette_cb
            // 
            this.vignette_cb.AutoSize = true;
            this.vignette_cb.Location = new System.Drawing.Point(552, 43);
            this.vignette_cb.Name = "vignette_cb";
            this.vignette_cb.Size = new System.Drawing.Size(18, 17);
            this.vignette_cb.TabIndex = 86;
            this.vignette_cb.UseVisualStyleBackColor = true;
            // 
            // depth_blur_cb
            // 
            this.depth_blur_cb.AutoSize = true;
            this.depth_blur_cb.Location = new System.Drawing.Point(552, 265);
            this.depth_blur_cb.Name = "depth_blur_cb";
            this.depth_blur_cb.Size = new System.Drawing.Size(18, 17);
            this.depth_blur_cb.TabIndex = 94;
            this.depth_blur_cb.UseVisualStyleBackColor = true;
            // 
            // depth_blur_scale
            // 
            this.depth_blur_scale.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.depth_blur_scale.Depth = 0;
            this.depth_blur_scale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.depth_blur_scale.Location = new System.Drawing.Point(567, 252);
            this.depth_blur_scale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.depth_blur_scale.MouseState = MaterialSkin.MouseState.HOVER;
            this.depth_blur_scale.Name = "depth_blur_scale";
            this.depth_blur_scale.Size = new System.Drawing.Size(220, 40);
            this.depth_blur_scale.TabIndex = 93;
            this.depth_blur_scale.Text = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(549, 229);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 20);
            this.label16.TabIndex = 92;
            this.label16.Text = "Depth Blur Scale";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 543);
            this.Controls.Add(this.depth_blur_cb);
            this.Controls.Add(this.depth_blur_scale);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.vrs_cb);
            this.Controls.Add(this.fsr3_cb);
            this.Controls.Add(this.cfm_cb);
            this.Controls.Add(this.cfq_cb);
            this.Controls.Add(this.vignette_cb);
            this.Controls.Add(this.vol_fog_cb);
            this.Controls.Add(this.distorsion_switch_cb);
            this.Controls.Add(this.bokeh_switch_cb);
            this.Controls.Add(this.fog_swith_cb);
            this.Controls.Add(this.reflection_cb);
            this.Controls.Add(this.ssr_cb);
            this.Controls.Add(this.bileteral_filter_cb);
            this.Controls.Add(this.dlss_denoizer_cb);
            this.Controls.Add(this.shadow_denoiser_cb);
            this.Controls.Add(this.dof_cb);
            this.Controls.Add(this.post_process_cb);
            this.Controls.Add(this.bloom_quality_cb);
            this.Controls.Add(this.motion_blur_cb);
            this.Controls.Add(this.dist_level_cb);
            this.Controls.Add(this.delete_mod_button);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.persets_combo);
            this.Controls.Add(this.fsr3_frames);
            this.Controls.Add(this.enable_vrs);
            this.Controls.Add(this.enable_bokeh);
            this.Controls.Add(this.vol_fog);
            this.Controls.Add(this.enable_fog);
            this.Controls.Add(this.disable_distortion);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.vignette_quality);
            this.Controls.Add(this.scene_color_fringe_max);
            this.Controls.Add(this.color_fringe_quality);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.distortion_level);
            this.Controls.Add(this.temporal_reflaction);
            this.Controls.Add(this.space_screen_recon);
            this.Controls.Add(this.bileteral_filter);
            this.Controls.Add(this.dlss_denoizer);
            this.Controls.Add(this.dof_level);
            this.Controls.Add(this.aa_quality);
            this.Controls.Add(this.blum_quality);
            this.Controls.Add(this.motion_blur);
            this.Controls.Add(this.shadow_denoiser);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Antifog";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button save_button;
        private MaterialSlider shadow_denoiser;
        private MaterialSlider motion_blur;
        private MaterialSlider blum_quality;
        private MaterialSlider aa_quality;
        private MaterialSlider dof_level;
        private MaterialSlider dlss_denoizer;
        private MaterialSlider bileteral_filter;
        private MaterialSlider space_screen_recon;
        private MaterialSlider temporal_reflaction;
        private MaterialSlider distortion_level;
        private MaterialSlider vignette_quality;
        private MaterialSlider scene_color_fringe_max;
        private MaterialSlider color_fringe_quality;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label14;
        private Label label21;
        private Label label22;
        private MaterialSwitch disable_distortion;
        private MaterialSwitch enable_fog;
        private MaterialSwitch vol_fog;
        private MaterialSwitch enable_bokeh;
        private MaterialSwitch enable_vrs;
        private MaterialSwitch fsr3_frames;
        private ComboBox persets_combo;
        private Label label15;
        private Button delete_mod_button;
        private CheckBox dist_level_cb;
        private CheckBox motion_blur_cb;
        private CheckBox bloom_quality_cb;
        private CheckBox post_process_cb;
        private CheckBox dof_cb;
        private CheckBox shadow_denoiser_cb;
        private CheckBox bokeh_switch_cb;
        private CheckBox fog_swith_cb;
        private CheckBox reflection_cb;
        private CheckBox ssr_cb;
        private CheckBox bileteral_filter_cb;
        private CheckBox dlss_denoizer_cb;
        private CheckBox distorsion_switch_cb;
        private CheckBox vol_fog_cb;
        private CheckBox vrs_cb;
        private CheckBox fsr3_cb;
        private CheckBox cfm_cb;
        private CheckBox cfq_cb;
        private CheckBox vignette_cb;
        private CheckBox depth_blur_cb;
        private MaterialSlider depth_blur_scale;
        private Label label16;
    }
}

