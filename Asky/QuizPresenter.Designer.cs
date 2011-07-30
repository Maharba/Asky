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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.tableLayoutAnswersPanel = new System.Windows.Forms.TableLayoutPanel();
            this.gbQuestions.SuspendLayout();
            this.tableLayoutMainPanel.SuspendLayout();
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
            this.gbQuestions.Size = new System.Drawing.Size(567, 385);
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
            this.tableLayoutMainPanel.Controls.Add(this.lblQuestion, 0, 0);
            this.tableLayoutMainPanel.Controls.Add(this.tableLayoutAnswersPanel, 0, 1);
            this.tableLayoutMainPanel.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutMainPanel.Name = "tableLayoutMainPanel";
            this.tableLayoutMainPanel.RowCount = 2;
            this.tableLayoutMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMainPanel.Size = new System.Drawing.Size(555, 360);
            this.tableLayoutMainPanel.TabIndex = 0;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(3, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(50, 13);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Pregunta";
            // 
            // tableLayoutAnswersPanel
            // 
            this.tableLayoutAnswersPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutAnswersPanel.ColumnCount = 1;
            this.tableLayoutAnswersPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutAnswersPanel.Location = new System.Drawing.Point(3, 183);
            this.tableLayoutAnswersPanel.Name = "tableLayoutAnswersPanel";
            this.tableLayoutAnswersPanel.RowCount = 1;
            this.tableLayoutAnswersPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutAnswersPanel.Size = new System.Drawing.Size(549, 174);
            this.tableLayoutAnswersPanel.TabIndex = 1;
            // 
            // QuizPresenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbQuestions);
            this.Name = "QuizPresenter";
            this.Size = new System.Drawing.Size(573, 391);
            this.gbQuestions.ResumeLayout(false);
            this.tableLayoutMainPanel.ResumeLayout(false);
            this.tableLayoutMainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbQuestions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMainPanel;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutAnswersPanel;
    }
}
