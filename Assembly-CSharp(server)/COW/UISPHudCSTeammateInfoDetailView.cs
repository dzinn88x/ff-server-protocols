using System;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200160C RID: 5644
	[Token(Token = "0x200160C")]
	public class UISPHudCSTeammateInfoDetailView : MonoBehaviour
	{
		// Token: 0x0600652E RID: 25902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600652E")]
		[Address(RVA = "0x1EE3C20", Offset = "0x1EE3C20", VA = "0x7BBC6E3C20")]
		public void UpdateHelmetStats({QAb\u0082~u playerID)
		{
		}

		// Token: 0x0600652F RID: 25903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600652F")]
		[Address(RVA = "0x1EE41CC", Offset = "0x1EE41CC", VA = "0x7BBC6E41CC")]
		public void UpdateArmorStats({QAb\u0082~u playerID)
		{
		}

		// Token: 0x06006530 RID: 25904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006530")]
		[Address(RVA = "0x1EE409C", Offset = "0x1EE409C", VA = "0x7BBC6E409C")]
		public void ClearHelmetState()
		{
		}

		// Token: 0x06006531 RID: 25905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006531")]
		[Address(RVA = "0x1EE4648", Offset = "0x1EE4648", VA = "0x7BBC6E4648")]
		public void ClearArmorStats()
		{
		}

		// Token: 0x06006532 RID: 25906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006532")]
		[Address(RVA = "0x1EE4778", Offset = "0x1EE4778", VA = "0x7BBC6E4778")]
		public UISPHudCSTeammateInfoDetailView()
		{
		}

		// Token: 0x04008377 RID: 33655
		[Token(Token = "0x4008377")]
		[FieldOffset(Offset = "0x18")]
		public GameObject HP;

		// Token: 0x04008378 RID: 33656
		[Token(Token = "0x4008378")]
		[FieldOffset(Offset = "0x20")]
		public UISprite Hpbarfg;

		// Token: 0x04008379 RID: 33657
		[Token(Token = "0x4008379")]
		[FieldOffset(Offset = "0x28")]
		public UILabel NameTxt;

		// Token: 0x0400837A RID: 33658
		[Token(Token = "0x400837A")]
		[FieldOffset(Offset = "0x30")]
		public TweenPosition TWNamePosition;

		// Token: 0x0400837B RID: 33659
		[Token(Token = "0x400837B")]
		[FieldOffset(Offset = "0x38")]
		public TweenAlpha TWNameAlpha;

		// Token: 0x0400837C RID: 33660
		[Token(Token = "0x400837C")]
		[FieldOffset(Offset = "0x40")]
		public UISprite HelmetBG;

		// Token: 0x0400837D RID: 33661
		[Token(Token = "0x400837D")]
		[FieldOffset(Offset = "0x48")]
		public UISprite FilledHelmet;

		// Token: 0x0400837E RID: 33662
		[Token(Token = "0x400837E")]
		[FieldOffset(Offset = "0x50")]
		public UISprite FilledHelmetEnhanced;

		// Token: 0x0400837F RID: 33663
		[Token(Token = "0x400837F")]
		[FieldOffset(Offset = "0x58")]
		public UISprite HelmetLevel;

		// Token: 0x04008380 RID: 33664
		[Token(Token = "0x4008380")]
		[FieldOffset(Offset = "0x60")]
		public UISprite ArmorBG;

		// Token: 0x04008381 RID: 33665
		[Token(Token = "0x4008381")]
		[FieldOffset(Offset = "0x68")]
		public UISprite FilledArmor;

		// Token: 0x04008382 RID: 33666
		[Token(Token = "0x4008382")]
		[FieldOffset(Offset = "0x70")]
		public UISprite FilledArmorEnhanced;

		// Token: 0x04008383 RID: 33667
		[Token(Token = "0x4008383")]
		[FieldOffset(Offset = "0x78")]
		public UISprite ArmorLevel;

		// Token: 0x04008384 RID: 33668
		[Token(Token = "0x4008384")]
		[FieldOffset(Offset = "0x80")]
		public TweenAlpha TWMoneyAlpha;

		// Token: 0x04008385 RID: 33669
		[Token(Token = "0x4008385")]
		[FieldOffset(Offset = "0x88")]
		public UISprite WeaponIconMain1;

		// Token: 0x04008386 RID: 33670
		[Token(Token = "0x4008386")]
		[FieldOffset(Offset = "0x90")]
		public TweenAlpha WeaponTween1;

		// Token: 0x04008387 RID: 33671
		[Token(Token = "0x4008387")]
		[FieldOffset(Offset = "0x98")]
		public GameObject FireEffectGo1;

		// Token: 0x04008388 RID: 33672
		[Token(Token = "0x4008388")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite WeaponIconMain2;

		// Token: 0x04008389 RID: 33673
		[Token(Token = "0x4008389")]
		[FieldOffset(Offset = "0xA8")]
		public TweenAlpha WeaponTween2;

		// Token: 0x0400838A RID: 33674
		[Token(Token = "0x400838A")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject FireEffectGo2;

		// Token: 0x0400838B RID: 33675
		[Token(Token = "0x400838B")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject SelectBG;

		// Token: 0x0400838C RID: 33676
		[Token(Token = "0x400838C")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject BombIcon;

		// Token: 0x0400838D RID: 33677
		[Token(Token = "0x400838D")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject PliersIcon;

		// Token: 0x0400838E RID: 33678
		[Token(Token = "0x400838E")]
		[FieldOffset(Offset = "0xD0")]
		[HideInInspector]
		private int curHelmetLevel;

		// Token: 0x0400838F RID: 33679
		[Token(Token = "0x400838F")]
		[FieldOffset(Offset = "0xD4")]
		private int curArmorLevel;

		// Token: 0x04008390 RID: 33680
		[Token(Token = "0x4008390")]
		[FieldOffset(Offset = "0xD8")]
		private string FilledArmorIcon;

		// Token: 0x04008391 RID: 33681
		[Token(Token = "0x4008391")]
		[FieldOffset(Offset = "0xE0")]
		private string FilledArmorIconBG;

		// Token: 0x04008392 RID: 33682
		[Token(Token = "0x4008392")]
		[FieldOffset(Offset = "0xE8")]
		private string FilledArmorIconExplode;

		// Token: 0x04008393 RID: 33683
		[Token(Token = "0x4008393")]
		[FieldOffset(Offset = "0xF0")]
		private string FilledArmorIconExplodeBG;

		// Token: 0x04008394 RID: 33684
		[Token(Token = "0x4008394")]
		[FieldOffset(Offset = "0xF8")]
		private string FilledHeadIcon;

		// Token: 0x04008395 RID: 33685
		[Token(Token = "0x4008395")]
		[FieldOffset(Offset = "0x100")]
		private string FilledHeadIconBG;

		// Token: 0x04008396 RID: 33686
		[Token(Token = "0x4008396")]
		[FieldOffset(Offset = "0x108")]
		private string FilledHeadIconProtect;

		// Token: 0x04008397 RID: 33687
		[Token(Token = "0x4008397")]
		[FieldOffset(Offset = "0x110")]
		private string FilledHeadIconProtectBG;
	}
}
