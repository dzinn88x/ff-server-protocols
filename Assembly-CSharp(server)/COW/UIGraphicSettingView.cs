using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002248 RID: 8776
	[Token(Token = "0x2002248")]
	public class UIGraphicSettingView : UIBaseView
	{
		// Token: 0x0600BFA1 RID: 49057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFA1")]
		[Address(RVA = "0x1A865D8", Offset = "0x1A865D8", VA = "0x7BBC2865D8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFA2 RID: 49058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFA2")]
		[Address(RVA = "0x1A86B3C", Offset = "0x1A86B3C", VA = "0x7BBC286B3C")]
		public UIGraphicSettingView()
		{
		}

		// Token: 0x0400D25E RID: 53854
		[Token(Token = "0x400D25E")]
		[FieldOffset(Offset = "0x20")]
		public GameObject QUALITY;

		// Token: 0x0400D25F RID: 53855
		[Token(Token = "0x400D25F")]
		[FieldOffset(Offset = "0x28")]
		public UIToggle LowestQualityToggle;

		// Token: 0x0400D260 RID: 53856
		[Token(Token = "0x400D260")]
		[FieldOffset(Offset = "0x30")]
		public UIToggle LowQualityToggle;

		// Token: 0x0400D261 RID: 53857
		[Token(Token = "0x400D261")]
		[FieldOffset(Offset = "0x38")]
		public UIToggle HighQualityToggle;

		// Token: 0x0400D262 RID: 53858
		[Token(Token = "0x400D262")]
		[FieldOffset(Offset = "0x40")]
		public UIWidget ExtraQualitySetting;

		// Token: 0x0400D263 RID: 53859
		[Token(Token = "0x400D263")]
		[FieldOffset(Offset = "0x48")]
		public UISprite ExtraSettingBG;

		// Token: 0x0400D264 RID: 53860
		[Token(Token = "0x400D264")]
		[FieldOffset(Offset = "0x50")]
		public GameObject resolutionObj;

		// Token: 0x0400D265 RID: 53861
		[Token(Token = "0x400D265")]
		[FieldOffset(Offset = "0x58")]
		public GameObject ShadowGO;

		// Token: 0x0400D266 RID: 53862
		[Token(Token = "0x400D266")]
		[FieldOffset(Offset = "0x60")]
		public UISettingToggleGroup ShadowOpToggleGroup;

		// Token: 0x0400D267 RID: 53863
		[Token(Token = "0x400D267")]
		[FieldOffset(Offset = "0x68")]
		public UIWidget InGameFilter;

		// Token: 0x0400D268 RID: 53864
		[Token(Token = "0x400D268")]
		[FieldOffset(Offset = "0x70")]
		public UIToggleButton Filter2Btn;

		// Token: 0x0400D269 RID: 53865
		[Token(Token = "0x400D269")]
		[FieldOffset(Offset = "0x78")]
		public UIToggleButton Filter3Btn;

		// Token: 0x0400D26A RID: 53866
		[Token(Token = "0x400D26A")]
		[FieldOffset(Offset = "0x80")]
		public GameObject Filter3BtnTips;

		// Token: 0x0400D26B RID: 53867
		[Token(Token = "0x400D26B")]
		[FieldOffset(Offset = "0x88")]
		public UIToggleButton Filter4Btn;

		// Token: 0x0400D26C RID: 53868
		[Token(Token = "0x400D26C")]
		[FieldOffset(Offset = "0x90")]
		public GameObject Filter4BtnTips;

		// Token: 0x0400D26D RID: 53869
		[Token(Token = "0x400D26D")]
		[FieldOffset(Offset = "0x98")]
		public UIToggleButton Filter1Btn;

		// Token: 0x0400D26E RID: 53870
		[Token(Token = "0x400D26E")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel Desc;

		// Token: 0x0400D26F RID: 53871
		[Token(Token = "0x400D26F")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject line1;

		// Token: 0x0400D270 RID: 53872
		[Token(Token = "0x400D270")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject HightFPSGO;

		// Token: 0x0400D271 RID: 53873
		[Token(Token = "0x400D271")]
		[FieldOffset(Offset = "0xB8")]
		public UISettingToggleGroup HighFPSToggleGroup;

		// Token: 0x0400D272 RID: 53874
		[Token(Token = "0x400D272")]
		[FieldOffset(Offset = "0xC0")]
		public UIToggle HighFPS_off;
	}
}
