using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Matrix
{

    public partial class ProfilePanel : Form
    {
        public ProfilePanel(string pic)
        {
            InitializeComponent();
            PicName = pic;
        }

        public static string img_Dir;
        private string PicName="";
        int imageInceament;
        bool isStreaming = false;
        VideoCaptureDevice videoCapture;
        FilterInfoCollection filterInfo;
        private int device = 0;
       

        private void ProfilePanel_Load(object sender, EventArgs e)
        {
            StartCam();
            DeviceLabel.Text = "Device: " + device.ToString();
        }

        void StartCam()
        {
            try
            {
               // int device = Convert.ToInt32(DeviceMenu.SelectedIndex);
                if (device >= 0)
                {
                    if(!isStreaming)
                    {
                        isStreaming = true;
                        StartCamButton.Text = "Stop Cam";

                        filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                        videoCapture = new VideoCaptureDevice(filterInfo[device].MonikerString);
                        videoCapture.NewFrame += new NewFrameEventHandler(Cam_On);
                        videoCapture.Start();
                    }
                    else
                    {
                        StartCamButton.Text = "Start Cam";
                        videoCapture.SignalToStop();
                        isStreaming = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cam_On(object sender, NewFrameEventArgs eventArgs)
        {
            CamBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void StartCamButton_Click(object sender, EventArgs e)
        {
            StartCam();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            try 
            {
                videoCapture.SignalToStop();
                isStreaming = false;
                this.Dispose();

            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void ChangeCam_Click(object sender, EventArgs e)
        {
            try
            {
                device++;
                DeviceLabel.Text = "Device: " + device.ToString();
                videoCapture = new VideoCaptureDevice(filterInfo[device].MonikerString);
            }catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void DeviceMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CaptureButton_Click(object sender, EventArgs e)
        {
            PictureBox.Image = CamBox.Image;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveImage();
        }

        private void SaveImage()
        {
            imageInceament++;

            try
            {

                if (isStreaming)
                {
                    if(PictureBox.Image != null)
                    {
                        img_Dir = @"C:\GYM_Matrix\MembersProfiles\" + PicName +".jpeg";
                        ImageFormat imgFormat = ImageFormat.Jpeg;
                        int width = PictureBox.Image.Width*5;
                        int height = PictureBox.Image.Height * 5;
                        var BitMap = new Bitmap(width, height);
                        //PictureBox.DrawToBitmap(BitMap, PictureBox.ClientRectangle);

                        using (Graphics g = Graphics.FromImage(BitMap))
                        {
                            g.DrawImage(PictureBox.Image, 0, 0, width, height);
                        }

                        BitMap.Save(img_Dir,imgFormat);
                        MessageBox.Show($"Picture Have been saved to {img_Dir}");
                    }
                }
                else { MessageBox.Show("Start Camera to Save Pic"); }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.ShowDialog();
                if (isStreaming)
                {
                    img_Dir = dialog.FileName;
                    PictureBox.Image = Image.FromFile(img_Dir);
                }

            }catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
