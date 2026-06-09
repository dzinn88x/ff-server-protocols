using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001948 RID: 6472
	[Token(Token = "0x2001948")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5E8C", Offset = "0x10F5E8C")]
	public class UIHudRedEnvelopeReceiveController : UIBaseController
	{
		// Token: 0x0600833B RID: 33595 RVA: 0x00023A78 File Offset: 0x00021C78
		[Token(Token = "0x600833B")]
		[Address(RVA = "0x17EF9F0", Offset = "0x17EF9F0", VA = "0x7BBBFEF9F0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600833C RID: 33596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600833C")]
		[Address(RVA = "0x17EFA40", Offset = "0x17EFA40", VA = "0x7BBBFEFA40", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600833D RID: 33597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600833D")]
		[Address(RVA = "0x17EFCB8", Offset = "0x17EFCB8", VA = "0x7BBBFEFCB8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600833E RID: 33598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600833E")]
		[Address(RVA = "0x17EFDD8", Offset = "0x17EFDD8", VA = "0x7BBBFEFDD8")]
		private void ShowReceiveWindow(params object[] param)
		{
		}

		// Token: 0x0600833F RID: 33599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600833F")]
		[Address(RVA = "0x17F0024", Offset = "0x17F0024", VA = "0x7BBBFF0024")]
		private void UpdateUI(LevelRedEnvelope levelRed)
		{
		}

		// Token: 0x06008340 RID: 33600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008340")]
		[Address(RVA = "0x17F0344", Offset = "0x17F0344", VA = "0x7BBBFF0344")]
		private void OnRedEnvelopeReceived(params object[] param)
		{
		}

		// Token: 0x06008341 RID: 33601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008341")]
		[Address(RVA = "0x17F0588", Offset = "0x17F0588", VA = "0x7BBBFF0588")]
		private void OnClickOpenButton()
		{
		}

		// Token: 0x06008342 RID: 33602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008342")]
		[Address(RVA = "0x17F062C", Offset = "0x17F062C", VA = "0x7BBBFF062C")]
		private void OnClickReceiveInfo()
		{
		}

		// Token: 0x06008343 RID: 33603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008343")]
		[Address(RVA = "0x17F0D7C", Offset = "0x17F0D7C", VA = "0x7BBBFF0D7C")]
		private void OnClickCloseButton()
		{
		}

		// Token: 0x06008344 RID: 33604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008344")]
		[Address(RVA = "0x17F0D8C", Offset = "0x17F0D8C", VA = "0x7BBBFF0D8C")]
		public UIHudRedEnvelopeReceiveController()
		{
		}

		// Token: 0x0400942D RID: 37933
		[Token(Token = "0x400942D")]
		[FieldOffset(Offset = "0x58")]
		private UIHudRedEnvelopeReceiveWindowView m_View;

		// Token: 0x0400942E RID: 37934
		[Token(Token = "0x400942E")]
		[FieldOffset(Offset = "0x60")]
		private uint lastLvlObjID;
	}
}
