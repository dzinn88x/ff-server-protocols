using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001666 RID: 5734
	[Token(Token = "0x2001666")]
	public class SettingTipsCompoment : MonoBehaviour
	{
		// Token: 0x060067B8 RID: 26552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067B8")]
		[Address(RVA = "0x1B360B4", Offset = "0x1B360B4", VA = "0x7BBC3360B4")]
		public void Awake()
		{
		}

		// Token: 0x060067B9 RID: 26553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067B9")]
		[Address(RVA = "0x1B36210", Offset = "0x1B36210", VA = "0x7BBC336210")]
		private void OnSettingTipsClick()
		{
		}

		// Token: 0x060067BA RID: 26554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067BA")]
		[Address(RVA = "0x1B36330", Offset = "0x1B36330", VA = "0x7BBC336330")]
		private void ShowTips()
		{
		}

		// Token: 0x060067BB RID: 26555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067BB")]
		[Address(RVA = "0x1B36280", Offset = "0x1B36280", VA = "0x7BBC336280")]
		private void ShowCDNWindow()
		{
		}

		// Token: 0x060067BC RID: 26556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067BC")]
		[Address(RVA = "0x1B36494", Offset = "0x1B36494", VA = "0x7BBC336494")]
		public SettingTipsCompoment()
		{
		}

		// Token: 0x040084E8 RID: 34024
		[Token(Token = "0x40084E8")]
		[FieldOffset(Offset = "0x18")]
		public UIButton TipsBtn;

		// Token: 0x040084E9 RID: 34025
		[Token(Token = "0x40084E9")]
		[FieldOffset(Offset = "0x20")]
		public TIPS_SHOWTYPE TipsType;

		// Token: 0x040084EA RID: 34026
		[Token(Token = "0x40084EA")]
		[FieldOffset(Offset = "0x28")]
		public string WebUrl;

		// Token: 0x040084EB RID: 34027
		[Token(Token = "0x40084EB")]
		[FieldOffset(Offset = "0x30")]
		public string WindowTitle;

		// Token: 0x040084EC RID: 34028
		[Token(Token = "0x40084EC")]
		[FieldOffset(Offset = "0x38")]
		public string TipsKey;
	}
}
