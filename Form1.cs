using System;
using System.IO;
using System.Windows.Forms;


namespace SHR_HideSetting
{

    public partial class Form1 : Form
    {
        string path = Environment.ExpandEnvironmentVariables(@"%LOCALAPPDATA%\SilentHill2\Saved\Config\Windows\Engine.ini");
        IniFile iniFile;

        public Form1()
        {
            //SetStyle(ControlStyles.UserPaint, true);
            InitializeComponent();
        }

        private int GetFormIni(string key, string value, IniFile ini, int def_value) 
        {

            if (ini.KeyExists(key, value))
            {
                return ini.ReadInt(key, value);
            }
            else
            {
                return def_value;
            }
        }
        
        private bool GetFormIni(string key, string value, IniFile ini, bool def_value) 
        {

            if (ini.KeyExists(key, value))
            {
                return true ? ini.ReadInt(key, value) == 1 : false;
            }
            else
            {
                return def_value;
            }
        }

        private void LoadData(IniFile iniFile)
        {
            //Sliders
            distortion_level.Value = this.GetFormIni("r.Distortion", "SystemSettings", iniFile, 0);
            motion_blur.Value = this.GetFormIni("r.motionblurquality", "SystemSettings", iniFile, 0);
            blum_quality.Value = this.GetFormIni("r.BloomQuality", "SystemSettings", iniFile, 0);
            aa_quality.Value = this.GetFormIni("r.PostProcessAAQuality", "SystemSettings", iniFile, 10);
            dof_level.Value = this.GetFormIni("r.DepthOfField.DepthBlur.Scale", "SystemSettings", iniFile, 0);
            shadow_denoiser.Value = this.GetFormIni("r.Shadow.Denoiser", "SystemSettings", iniFile, 10);
            dlss_denoizer.Value = this.GetFormIni("r.NGX.DLSS.denoisermode", "SystemSettings", iniFile, 10);
            bileteral_filter.Value = this.GetFormIni("r.Lumen.Reflections.BilateralFilter", "SystemSettings", iniFile, 10);
            space_screen_recon.Value = this.GetFormIni("r.Lumen.Reflections.ScreenSpaceReconstruction", "SystemSettings", iniFile, 10);
            temporal_reflaction.Value = this.GetFormIni("r.lumen.Reflections.Temporal", "SystemSettings", iniFile, 10);
            vignette_quality.Value = this.GetFormIni("r.Tonemapper.Quality", "SystemSettings", iniFile, 0);
            color_fringe_quality.Value = this.GetFormIni("r.SceneColorFringeQuality", "SystemSettings", iniFile, 0);
            scene_color_fringe_max.Value = this.GetFormIni("r.SceneColorFringe.Max", "SystemSettings", iniFile, 0);
            depth_blur_scale.Value = this.GetFormIni("r.DepthOfField.DepthBlur.Scale", "SystemSettings", iniFile, 0);

            //Checkboxes
            disable_distortion.Checked = this.GetFormIni("r.DisableDistortion", "SystemSettings", iniFile, true);
            enable_fog.Checked = this.GetFormIni("r.Fog", "SystemSettings", iniFile, true);
            vol_fog.Checked = this.GetFormIni("r.volumetricfog", "SystemSettings", iniFile, true);
            enable_bokeh.Checked = this.GetFormIni("r.DOF.Gather.EnableBokehSettings", "SystemSettings", iniFile, false);
            enable_vrs.Checked = this.GetFormIni("r.Vrs.Enable", "SystemSettings", iniFile, false);
            fsr3_frames.Checked = this.GetFormIni("r.FidelityFX.FI.Enabled", "SystemSettings", iniFile, false);
        }

        private bool Show_Error_Message()
        {

            if (!File.Exists(path))
            {
                MessageBox.Show("Settings file not found! Please, run a 'Silent Hill 2 Remake' game once, to create all files!",
                    "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Checkbox_switcher(bool state, bool fog=true)
        {
            dist_level_cb.Checked = state;
            motion_blur_cb.Checked = state;
            bloom_quality_cb.Checked = state;
            post_process_cb.Checked = state;
            dof_cb.Checked = state;
            shadow_denoiser_cb.Checked = state;
            bokeh_switch_cb.Checked = state;
            fog_swith_cb.Checked = fog;
            reflection_cb.Checked = state;
            ssr_cb.Checked = state;
            bileteral_filter_cb.Checked = state;
            dlss_denoizer_cb.Checked = state;
            distorsion_switch_cb.Checked = state;
            vol_fog_cb.Checked = fog;
            vrs_cb.Checked = state;
            fsr3_cb.Checked = state;
            cfm_cb.Checked = state;
            cfq_cb.Checked = state;
            vignette_cb.Checked = state;
            depth_blur_cb.Checked = state;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip tooltip = new ToolTip(); 
            String tooltip_msg = "Checked - write this option to setting\n" +
                               "Unchecked - use default game setting";
            shadow_denoiser.RangeMax = 10;
            motion_blur.RangeMax = 10;
            blum_quality.RangeMax = 10;
            aa_quality.RangeMax = 10;
            dof_level.RangeMax = 10;
            dlss_denoizer.RangeMax = 10;
            bileteral_filter.RangeMax = 10;
            space_screen_recon.RangeMax = 10;
            temporal_reflaction.RangeMax = 10;
            distortion_level.RangeMax = 10;
            vignette_quality.RangeMax = 10;
            color_fringe_quality.RangeMax = 10;
            scene_color_fringe_max.RangeMax = 10;
            depth_blur_scale.RangeMax = 10;
            this.Checkbox_switcher(true);

            tooltip.SetToolTip(dist_level_cb, tooltip_msg);
            tooltip.SetToolTip(motion_blur_cb, tooltip_msg);
            tooltip.SetToolTip(bloom_quality_cb, tooltip_msg);
            tooltip.SetToolTip(post_process_cb, tooltip_msg);
            tooltip.SetToolTip(dof_cb, tooltip_msg);
            tooltip.SetToolTip(shadow_denoiser_cb, tooltip_msg);
            tooltip.SetToolTip(bokeh_switch_cb, tooltip_msg);
            tooltip.SetToolTip(fog_swith_cb, tooltip_msg);
            tooltip.SetToolTip(reflection_cb, tooltip_msg);
            tooltip.SetToolTip(ssr_cb, tooltip_msg);
            tooltip.SetToolTip(bileteral_filter_cb, tooltip_msg);
            tooltip.SetToolTip(dlss_denoizer_cb, tooltip_msg);
            tooltip.SetToolTip(distorsion_switch_cb, tooltip_msg);
            tooltip.SetToolTip(vol_fog_cb, tooltip_msg);
            tooltip.SetToolTip(vrs_cb, tooltip_msg);
            tooltip.SetToolTip(fsr3_cb, tooltip_msg);
            tooltip.SetToolTip(cfm_cb, tooltip_msg);
            tooltip.SetToolTip(cfq_cb, tooltip_msg);
            tooltip.SetToolTip(vignette_cb, tooltip_msg);
            tooltip.SetToolTip(depth_blur_cb, tooltip_msg);

            string[] presets = { "Quality", "Balance", "Performance", "Quality+Effects", "Fog disable only" };
            persets_combo.Items.AddRange(presets);
            persets_combo.SelectedIndex = Array.IndexOf(presets, "Quality");

            iniFile = new IniFile(path);
            this.LoadData(iniFile);
            this.Show_Error_Message();
        }

        private void cancel_settings(object sender, EventArgs e)
        {
            this.LoadData(iniFile);
        }

        private string bool2string(bool b)
        {
            if (b)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }

        private void apply_settings(object sender, EventArgs e)
        {

            if (this.Show_Error_Message())
            {
                //Sliders
                if (dist_level_cb.Checked == true)
                {
                    iniFile.Write("r.Distortion", distortion_level.Value.ToString(), "SystemSettings");
                }
                else {
                    iniFile.DeleteKey("r.Distortion", "SystemSettings");
                }

                if (motion_blur_cb.Checked != true)
                {
                    iniFile.Write("r.motionblurquality", motion_blur.Value.ToString(), "SystemSettings");
                } else
                {
                    iniFile.DeleteKey("r.motionblurquality", "SystemSettings");
                }

                if (bloom_quality_cb.Checked == true)
                {
                    iniFile.Write("r.BloomQuality", blum_quality.Value.ToString(), "SystemSettings");
                } else
                {
                    iniFile.DeleteKey("r.BloomQuality", "SystemSettings");
                }

                if (post_process_cb.Checked == true)
                {
                    iniFile.Write("r.PostProcessAAQuality", aa_quality.Value.ToString(), "SystemSettings");
                }
                else
                {
                    iniFile.DeleteKey("r.PostProcessAAQuality", "SystemSettings");
                }

                if (dof_cb.Checked == true)
                {
                    iniFile.Write("r.DepthOfField.DepthBlur.Scale", dof_level.Value.ToString(), "SystemSettings");
                }
                else
                {
                    iniFile.DeleteKey("r.DepthOfField.DepthBlur.Scale", "SystemSettings");
                }
                
                if (shadow_denoiser_cb.Checked == true)
                {
                    iniFile.Write("r.Shadow.Denoiser", shadow_denoiser.Value.ToString(), "SystemSettings");
                }
                else
                {
                    iniFile.DeleteKey("r.Shadow.Denoiser", "SystemSettings");
                }
                
                if (dlss_denoizer_cb.Checked == true)
                {
                    iniFile.Write("r.NGX.DLSS.denoisermode", dlss_denoizer.Value.ToString(), "SystemSettings");
                }
                else
                {
                    iniFile.DeleteKey("r.NGX.DLSS.denoisermode", "SystemSettings");
                }

                if (bileteral_filter_cb.Checked == true)
                {
                    iniFile.Write("r.Lumen.Reflections.BilateralFilter", bileteral_filter.Value.ToString(), "SystemSettings");
                }
                else
                {
                    iniFile.DeleteKey("r.Lumen.Reflections.BilateralFilter", "SystemSettings");
                }

                if (ssr_cb.Checked == true)
                {
                    iniFile.Write("r.Lumen.Reflections.ScreenSpaceReconstruction", space_screen_recon.Value.ToString(), "SystemSettings");
                }
                else
                {
                    iniFile.DeleteKey("r.Lumen.Reflections.ScreenSpaceReconstruction", "SystemSettings");
                }

                if (reflection_cb.Checked == true)
                {
                    iniFile.Write("r.lumen.Reflections.Temporal", temporal_reflaction.Value.ToString(), "SystemSettings");
                }
                else
                {
                    iniFile.DeleteKey("r.lumen.Reflections.Temporal", "SystemSettings");
                }

                if (vignette_cb.Checked == true)
                {
                    iniFile.Write("r.Tonemapper.Quality", vignette_quality.Value.ToString(), "SystemSettings");
                }
                else
                {
                    iniFile.DeleteKey("r.Tonemapper.Quality", "SystemSettings");
                }

                if (cfq_cb.Checked == true)
                {
                    iniFile.Write("r.SceneColorFringeQuality", color_fringe_quality.Value.ToString(), "SystemSettings");
                }
                else
                {
                    iniFile.DeleteKey("r.SceneColorFringeQuality", "SystemSettings");
                }

                if (cfm_cb.Checked == true)
                {
                    iniFile.Write("r.SceneColorFringe.Max", scene_color_fringe_max.Value.ToString(), "SystemSettings");
                }
                else
                {
                    iniFile.DeleteKey("r.SceneColorFringe.Max", "SystemSettings");
                }

                if (depth_blur_cb.Checked == true)
                {
                    iniFile.Write("r.DepthOfField.DepthBlur.Scale", depth_blur_scale.Value.ToString(), "SystemSettings");
                }
                else
                {
                    iniFile.DeleteKey("r.DepthOfField.DepthBlur.Scale", "SystemSettings");
                }


                //Checkboxes
                if (distorsion_switch_cb.Checked == true)
                {
                    iniFile.Write("r.DisableDistortion", this.bool2string(disable_distortion.Checked), "SystemSettings");
                }
                else
                {
                    iniFile.DeleteKey("r.DisableDistortion", "SystemSettings");
                }

                if (fog_swith_cb.Checked == true)
                {
                    iniFile.Write("r.Fog", this.bool2string(enable_fog.Checked), "SystemSettings");
                }
                else
                {
                    iniFile.DeleteKey("r.Fog", "SystemSettings");
                }

                if (vol_fog_cb.Checked == true)
                {
                    iniFile.Write("r.volumetricfog", this.bool2string(vol_fog.Checked), "SystemSettings");
                }
                else
                {
                    iniFile.DeleteKey("r.volumetricfog", "SystemSettings");
                }

                if (bokeh_switch_cb.Checked == true)
                {
                    iniFile.Write("r.DOF.Gather.EnableBokehSettings", this.bool2string(enable_bokeh.Checked), "SystemSettings");
                }
                else
                {
                    iniFile.DeleteKey("r.DOF.Gather.EnableBokehSettings", "SystemSettings");
                }

                if (vrs_cb.Checked == true)
                {
                    iniFile.Write("r.Vrs.Enable", this.bool2string(enable_vrs.Checked), "SystemSettings");
                }
                else
                {
                    iniFile.DeleteKey("r.Vrs.Enable", "SystemSettings");
                }

                if (fsr3_cb.Checked == true)
                {
                    iniFile.Write("r.FidelityFX.FI.Enabled", this.bool2string(fsr3_frames.Checked), "SystemSettings");
                }
                else
                {
                    iniFile.DeleteKey("r.FidelityFX.FI.Enabled", "SystemSettings");
                }

            }
        }

        private void delete_mod_button_Click(object sender, EventArgs e)
        {
            if (this.Show_Error_Message())
            {
                DialogResult answere = MessageBox.Show("Are you sure?", "DELITING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (answere == DialogResult.Yes)
                {
                    iniFile.DeleteSection("SystemSettings");
                    MessageBox.Show("Mod was deleted!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void load_preset(int[] ints, bool[] bools)
        {
            //Sliders
            distortion_level.Value = ints[0];
            motion_blur.Value = ints[1];
            blum_quality.Value = ints[2];
            aa_quality.Value = ints[3];
            dof_level.Value = ints[4];
            shadow_denoiser.Value = ints[5];
            dlss_denoizer.Value = ints[6];
            bileteral_filter.Value = ints[7];
            space_screen_recon.Value = ints[8];
            temporal_reflaction.Value = ints[9];
            vignette_quality.Value = ints[10];
            color_fringe_quality.Value = ints[11];
            scene_color_fringe_max.Value = ints[12];
            depth_blur_scale.Value = ints[13];

            //Checkboxes
            disable_distortion.Checked = bools[0];
            enable_fog.Checked = bools[1];
            vol_fog.Checked = bools[2];
            enable_bokeh.Checked = bools[3];
            enable_vrs.Checked = bools[4];
            fsr3_frames.Checked = bools[5];
        }

        private void persets_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cur_text = persets_combo.Text;
            int[] slider_data;
            bool[] checkbox_data;
            bool cb_status = true;

            if (cur_text == "Quality")
            {
                slider_data = new int[] { 0, 0, 10, 10, 0, 10, 10, 10, 10, 10, 0, 0, 0, 0 };
                checkbox_data = new bool[] { true, true, true, false, false, false };
            }

            else if (cur_text == "Quality+Effects")
            {
                slider_data = new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
                checkbox_data = new bool[] { false, true, true, true, false, false };
            }

            else if (cur_text == "Balance")
            {
                slider_data = new int[] { 0, 0, 10, 5, 0, 3, 3, 5, 3, 4, 0, 0, 0, 0 };
                checkbox_data = new bool[] { true, true, true, false, false, true };
            }

            else if (cur_text == "Performance")
            {
                slider_data = new int[] { 0, 10, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                checkbox_data = new bool[] { true, true, false, false, false, true };
            }

            else if (cur_text == "Fog disable only")
            {
                slider_data = new int[] { 0, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                checkbox_data = new bool[] { false, false, false, false, false, false };
                cb_status = false;
            }

            else
            {
                return;
            }

            this.load_preset(slider_data, checkbox_data);
            this.Checkbox_switcher(cb_status);
        }
    }
}
