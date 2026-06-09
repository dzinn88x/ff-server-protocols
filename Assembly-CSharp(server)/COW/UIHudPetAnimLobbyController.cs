using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001922 RID: 6434
	[Token(Token = "0x2001922")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F59C4", Offset = "0x10F59C4")]
	internal class UIHudPetAnimLobbyController : UIBaseController
	{
		// Token: 0x060081E9 RID: 33257 RVA: 0x00023658 File Offset: 0x00021858
		[Token(Token = "0x60081E9")]
		[Address(RVA = "0x1D6CC4C", Offset = "0x1D6CC4C", VA = "0x7BBC56CC4C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060081EA RID: 33258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081EA")]
		[Address(RVA = "0x1D6CC9C", Offset = "0x1D6CC9C", VA = "0x7BBC56CC9C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060081EB RID: 33259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081EB")]
		[Address(RVA = "0x1D6CE10", Offset = "0x1D6CE10", VA = "0x7BBC56CE10", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x060081EC RID: 33260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081EC")]
		[Address(RVA = "0x1D6CE18", Offset = "0x1D6CE18", VA = "0x7BBC56CE18")]
		public void InitBtns(List<PetActionData> anims)
		{
		}

		// Token: 0x060081ED RID: 33261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081ED")]
		[Address(RVA = "0x1D6D3D8", Offset = "0x1D6D3D8", VA = "0x7BBC56D3D8")]
		private void InitBtn(UIButton btn, UISprite sprite, PetActionData d)
		{
		}

		// Token: 0x060081EE RID: 33262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081EE")]
		[Address(RVA = "0x1D6D6F0", Offset = "0x1D6D6F0", VA = "0x7BBC56D6F0")]
		public void HidePanel()
		{
		}

		// Token: 0x060081EF RID: 33263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081EF")]
		[Address(RVA = "0x1D6D78C", Offset = "0x1D6D78C", VA = "0x7BBC56D78C")]
		private void OnClickAnim(PetActionData d)
		{
		}

		// Token: 0x060081F0 RID: 33264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081F0")]
		[Address(RVA = "0x1D6D8C4", Offset = "0x1D6D8C4", VA = "0x7BBC56D8C4")]
		public UIHudPetAnimLobbyController()
		{
		}

		// Token: 0x04009360 RID: 37728
		[Token(Token = "0x4009360")]
		[FieldOffset(Offset = "0x58")]
		private UIHudPetAnimView m_View;

		// Token: 0x04009361 RID: 37729
		[Token(Token = "0x4009361")]
		[FieldOffset(Offset = "0x60")]
		private bool m_HasAnims;

		// Token: 0x02001923 RID: 6435
		[Token(Token = "0x2001923")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F59FC", Offset = "0x10F59FC")]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x060081F1 RID: 33265 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60081F1")]
			[Address(RVA = "0x1D6D6E8", Offset = "0x1D6D6E8", VA = "0x7BBC56D6E8")]
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x060081F2 RID: 33266 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60081F2")]
			[Address(RVA = "0x1D6D8CC", Offset = "0x1D6D8CC", VA = "0x7BBC56D8CC")]
			internal void <InitBtn>b__0()
			{
			}

			// Token: 0x04009362 RID: 37730
			[Token(Token = "0x4009362")]
			[FieldOffset(Offset = "0x10")]
			public UIHudPetAnimLobbyController <>4__this;

			// Token: 0x04009363 RID: 37731
			[Token(Token = "0x4009363")]
			[FieldOffset(Offset = "0x18")]
			public PetActionData d;
		}
	}
}
