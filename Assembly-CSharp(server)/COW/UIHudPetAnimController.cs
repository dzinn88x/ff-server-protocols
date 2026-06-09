using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001920 RID: 6432
	[Token(Token = "0x2001920")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F597C", Offset = "0x10F597C")]
	internal class UIHudPetAnimController : UIBaseController
	{
		// Token: 0x060081D9 RID: 33241 RVA: 0x00023640 File Offset: 0x00021840
		[Token(Token = "0x60081D9")]
		[Address(RVA = "0x1D6B658", Offset = "0x1D6B658", VA = "0x7BBC56B658")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060081DA RID: 33242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081DA")]
		[Address(RVA = "0x1D6B6A8", Offset = "0x1D6B6A8", VA = "0x7BBC56B6A8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060081DB RID: 33243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081DB")]
		[Address(RVA = "0x1D6B9B4", Offset = "0x1D6B9B4", VA = "0x7BBC56B9B4")]
		private void InitBtns(List<PetActionData> anims)
		{
		}

		// Token: 0x060081DC RID: 33244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081DC")]
		[Address(RVA = "0x1D6C0BC", Offset = "0x1D6C0BC", VA = "0x7BBC56C0BC")]
		private void InitBtn(UIButton btn, UISprite sprite, PetActionData d)
		{
		}

		// Token: 0x060081DD RID: 33245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081DD")]
		[Address(RVA = "0x1D6C3D4", Offset = "0x1D6C3D4", VA = "0x7BBC56C3D4", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x060081DE RID: 33246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081DE")]
		[Address(RVA = "0x1D6C41C", Offset = "0x1D6C41C", VA = "0x7BBC56C41C")]
		private void ShowPanel(bool show = true)
		{
		}

		// Token: 0x060081DF RID: 33247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081DF")]
		[Address(RVA = "0x1D6C47C", Offset = "0x1D6C47C", VA = "0x7BBC56C47C")]
		private void DoShowPanel()
		{
		}

		// Token: 0x060081E0 RID: 33248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081E0")]
		[Address(RVA = "0x1D6B9AC", Offset = "0x1D6B9AC", VA = "0x7BBC56B9AC")]
		private void HidePanel()
		{
		}

		// Token: 0x060081E1 RID: 33249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081E1")]
		[Address(RVA = "0x1D6C850", Offset = "0x1D6C850", VA = "0x7BBC56C850")]
		private void OnClickAnim(PetActionData d)
		{
		}

		// Token: 0x060081E2 RID: 33250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081E2")]
		[Address(RVA = "0x1D6CB60", Offset = "0x1D6CB60", VA = "0x7BBC56CB60")]
		private void OnClickCenterBtn()
		{
		}

		// Token: 0x060081E3 RID: 33251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081E3")]
		[Address(RVA = "0x1D6C6E4", Offset = "0x1D6C6E4", VA = "0x7BBC56C6E4")]
		private void RepositionPanel()
		{
		}

		// Token: 0x060081E4 RID: 33252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081E4")]
		[Address(RVA = "0x1D6C02C", Offset = "0x1D6C02C", VA = "0x7BBC56C02C")]
		private void UpdateCenterIcons()
		{
		}

		// Token: 0x060081E5 RID: 33253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081E5")]
		[Address(RVA = "0x1D6C9F0", Offset = "0x1D6C9F0", VA = "0x7BBC56C9F0")]
		private void ShowKey(string key)
		{
		}

		// Token: 0x060081E6 RID: 33254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081E6")]
		[Address(RVA = "0x1D6CC14", Offset = "0x1D6CC14", VA = "0x7BBC56CC14")]
		public UIHudPetAnimController()
		{
		}

		// Token: 0x0400935B RID: 37723
		[Token(Token = "0x400935B")]
		[FieldOffset(Offset = "0x58")]
		private UIHudPetAnimView m_View;

		// Token: 0x0400935C RID: 37724
		[Token(Token = "0x400935C")]
		[FieldOffset(Offset = "0x60")]
		private NetworkPet m_Pet;

		// Token: 0x0400935D RID: 37725
		[Token(Token = "0x400935D")]
		[FieldOffset(Offset = "0x68")]
		private bool m_HidePet;

		// Token: 0x02001921 RID: 6433
		[Token(Token = "0x2001921")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F59B4", Offset = "0x10F59B4")]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x060081E7 RID: 33255 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60081E7")]
			[Address(RVA = "0x1D6C3CC", Offset = "0x1D6C3CC", VA = "0x7BBC56C3CC")]
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x060081E8 RID: 33256 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60081E8")]
			[Address(RVA = "0x1D6CC1C", Offset = "0x1D6CC1C", VA = "0x7BBC56CC1C")]
			internal void <InitBtn>b__0()
			{
			}

			// Token: 0x0400935E RID: 37726
			[Token(Token = "0x400935E")]
			[FieldOffset(Offset = "0x10")]
			public UIHudPetAnimController <>4__this;

			// Token: 0x0400935F RID: 37727
			[Token(Token = "0x400935F")]
			[FieldOffset(Offset = "0x18")]
			public PetActionData d;
		}
	}
}
