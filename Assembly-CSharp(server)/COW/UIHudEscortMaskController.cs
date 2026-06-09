using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018B9 RID: 6329
	[Token(Token = "0x20018B9")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4AE4", Offset = "0x10F4AE4")]
	public class UIHudEscortMaskController : UIBaseController
	{
		// Token: 0x06007DEA RID: 32234 RVA: 0x000227E8 File Offset: 0x000209E8
		[Token(Token = "0x6007DEA")]
		[Address(RVA = "0x1C073DC", Offset = "0x1C073DC", VA = "0x7BBC4073DC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007DEB RID: 32235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DEB")]
		[Address(RVA = "0x1C0742C", Offset = "0x1C0742C", VA = "0x7BBC40742C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007DEC RID: 32236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DEC")]
		[Address(RVA = "0x1C07538", Offset = "0x1C07538", VA = "0x7BBC407538")]
		private void UpdateAlpha(float alpha)
		{
		}

		// Token: 0x06007DED RID: 32237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DED")]
		[Address(RVA = "0x1C0758C", Offset = "0x1C0758C", VA = "0x7BBC40758C")]
		private void Update()
		{
		}

		// Token: 0x06007DEE RID: 32238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007DEE")]
		[Address(RVA = "0x1C07708", Offset = "0x1C07708", VA = "0x7BBC407708")]
		public UIHudEscortMaskController()
		{
		}

		// Token: 0x0400914C RID: 37196
		[Token(Token = "0x400914C")]
		[FieldOffset(Offset = "0x58")]
		private UIHudEscortMaskView m_View;

		// Token: 0x0400914D RID: 37197
		[Token(Token = "0x400914D")]
		[FieldOffset(Offset = "0x60")]
		private rwKefBm m_Game;
	}
}
