using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200162F RID: 5679
	[Token(Token = "0x200162F")]
	public class UIPVEGameStartController : UILinkActivityDetailController
	{
		// Token: 0x06006633 RID: 26163 RVA: 0x0001D2C8 File Offset: 0x0001B4C8
		[Token(Token = "0x6006633")]
		[Address(RVA = "0x16E204C", Offset = "0x16E204C", VA = "0x7BBBEE204C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006634 RID: 26164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006634")]
		[Address(RVA = "0x16E209C", Offset = "0x16E209C", VA = "0x7BBBEE209C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006635 RID: 26165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006635")]
		[Address(RVA = "0x16E2348", Offset = "0x16E2348", VA = "0x7BBBEE2348", Slot = "30")]
		protected override void InitActivityInfo()
		{
		}

		// Token: 0x06006636 RID: 26166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006636")]
		[Address(RVA = "0x16E2794", Offset = "0x16E2794", VA = "0x7BBBEE2794")]
		private void InitActivityInfo(LinkActivityData data)
		{
		}

		// Token: 0x06006637 RID: 26167 RVA: 0x0001D2E0 File Offset: 0x0001B4E0
		[Token(Token = "0x6006637")]
		[Address(RVA = "0x16E2DF4", Offset = "0x16E2DF4", VA = "0x7BBBEE2DF4")]
		private bool InitRewardId(UISprite icon, uint id)
		{
			return default(bool);
		}

		// Token: 0x06006638 RID: 26168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006638")]
		[Address(RVA = "0x16E224C", Offset = "0x16E224C", VA = "0x7BBBEE224C")]
		private void InitStartMatchUI()
		{
		}

		// Token: 0x06006639 RID: 26169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006639")]
		[Address(RVA = "0x16E2F58", Offset = "0x16E2F58", VA = "0x7BBBEE2F58")]
		private void StartSoloGame()
		{
		}

		// Token: 0x0600663A RID: 26170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600663A")]
		[Address(RVA = "0x16E307C", Offset = "0x16E307C", VA = "0x7BBBEE307C")]
		private void StartGroupGame()
		{
		}

		// Token: 0x0600663B RID: 26171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600663B")]
		[Address(RVA = "0x16E3418", Offset = "0x16E3418", VA = "0x7BBBEE3418")]
		public UIPVEGameStartController()
		{
		}

		// Token: 0x0400840F RID: 33807
		[Token(Token = "0x400840F")]
		[FieldOffset(Offset = "0x70")]
		private UIPVEStartGameView m_View;

		// Token: 0x04008410 RID: 33808
		[Token(Token = "0x4008410")]
		[FieldOffset(Offset = "0x78")]
		private List<UIPVEGameStartRewardItemController> m_DailyAwardControllers;

		// Token: 0x04008411 RID: 33809
		[Token(Token = "0x4008411")]
		[FieldOffset(Offset = "0x80")]
		private MapOpeningInfo m_SelectMap;

		// Token: 0x04008412 RID: 33810
		[Token(Token = "0x4008412")]
		[FieldOffset(Offset = "0x88")]
		private UIModelPVE m_ModelPVE;
	}
}
