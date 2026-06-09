using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020023A5 RID: 9125
	[Token(Token = "0x20023A5")]
	public class UIHudWereWolvesInfoView : UIBaseView
	{
		// Token: 0x0600C25A RID: 49754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C25A")]
		[Address(RVA = "0x1D12ABC", Offset = "0x1D12ABC", VA = "0x7BBC512ABC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C25B RID: 49755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C25B")]
		[Address(RVA = "0x1D12D08", Offset = "0x1D12D08", VA = "0x7BBC512D08")]
		public UIHudWereWolvesInfoView()
		{
		}

		// Token: 0x0400DDAE RID: 56750
		[Token(Token = "0x400DDAE")]
		[FieldOffset(Offset = "0x20")]
		public UIProgressBar Progress;

		// Token: 0x0400DDAF RID: 56751
		[Token(Token = "0x400DDAF")]
		[FieldOffset(Offset = "0x28")]
		public GameObject TutorialEffect;

		// Token: 0x0400DDB0 RID: 56752
		[Token(Token = "0x400DDB0")]
		[FieldOffset(Offset = "0x30")]
		public UILabel ProgressLabel;

		// Token: 0x0400DDB1 RID: 56753
		[Token(Token = "0x400DDB1")]
		[FieldOffset(Offset = "0x38")]
		public UILabel TimerLabel;

		// Token: 0x0400DDB2 RID: 56754
		[Token(Token = "0x400DDB2")]
		[FieldOffset(Offset = "0x40")]
		public GameObject AlertNode;

		// Token: 0x0400DDB3 RID: 56755
		[Token(Token = "0x400DDB3")]
		[FieldOffset(Offset = "0x48")]
		public UILabel AlertCountDownLabel;

		// Token: 0x0400DDB4 RID: 56756
		[Token(Token = "0x400DDB4")]
		[FieldOffset(Offset = "0x50")]
		public UILabel AlertInfoLabel;

		// Token: 0x0400DDB5 RID: 56757
		[Token(Token = "0x400DDB5")]
		[FieldOffset(Offset = "0x58")]
		public GameObject WinAlertInfo;
	}
}
