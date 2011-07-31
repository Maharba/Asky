namespace Asky
{
    partial class QuizPresenter
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbQuestions = new System.Windows.Forms.GroupBox();
            this.tableLayoutMainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutAnswersPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.gbQuestions.SuspendLayout();
            this.tableLayoutMainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbQuestions
            // 
            this.gbQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbQuestions.Controls.Add(this.tableLayoutMainPanel);
            this.gbQuestions.Location = new System.Drawing.Point(3, 3);
            this.gbQuestions.Name = "gbQuestions";
            this.gbQuestions.Size = new System.Drawing.Size(288, 209);
            this.gbQuestions.TabIndex = 1;
            this.gbQuestions.TabStop = false;
            this.gbQuestions.Text = "Pregunta 0";
            // 
            // tableLayoutMainPanel
            // 
            this.tableLayoutMainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutMainPanel.ColumnCount = 1;
            this.tableLayoutMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMainPanel.Controls.Add(this.tableLayoutAnswersPanel, 0, 1);
            this.tableLayoutMainPanel.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutMainPanel.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutMainPanel.Name = "tableLayoutMainPanel";
            this.tableLayoutMainPanel.RowCount = 2;
            this.tableLayoutMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMainPanel.Size = new System.Drawing.Size(276, 184);
            this.tableLayoutMainPanel.TabIndex = 0;
            // 
            // tableLayoutAnswersPanel
            // 
            this.tableLayoutAnswersPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutAnswersPanel.ColumnCount = 1;
            this.tableLayoutAnswersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutAnswersPanel.Location = new System.Drawing.Point(3, 95);
            this.tableLayoutAnswersPanel.Name = "tableLayoutAnswersPanel";
            this.tableLayoutAnswersPanel.RowCount = 1;
            this.tableLayoutAnswersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutAnswersPanel.Size = new System.Drawing.Size(270, 86);
            this.tableLayoutAnswersPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lblQuestion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 86);
            this.panel1.TabIndex = 2;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(3, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(50, 13);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Pregunta";
            // 
            // QuizPresenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbQuestions);
            this.Name = "QuizPresenter";
            this.Size = new System.Drawing.Size(294, 215);
            this.gbQuestions.ResumeLayout(false);
            this.tableLayoutMainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbQuestions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMainPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutAnswersPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblQuestion;
    }
}
