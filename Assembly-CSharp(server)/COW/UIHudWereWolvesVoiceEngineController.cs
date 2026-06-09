using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020019A0 RID: 6560
	[Token(Token = "0x20019A0")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6BBC", Offset = "0x10F6BBC")]
	public class UIHudWereWolvesVoiceEngineController : UIBaseController
	{
		// Token: 0x06008637 RID: 34359 RVA: 0x000245B8 File Offset: 0x000227B8
		[Token(Token = "0x6008637")]
		[Address(RVA = "0x1D187A8", Offset = "0x1D187A8", VA = "0x7BBC5187A8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008638 RID: 34360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008638")]
		[Address(RVA = "0x1D187F8", Offset = "0x1D187F8", VA = "0x7BBC5187F8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008639 RID: 34361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008639")]
		[Address(RVA = "0x1D189B0", Offset = "0x1D189B0", VA = "0x7BBC5189B0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600863A RID: 34362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600863A")]
		[Address(RVA = "0x1D18A7C", Offset = "0x1D18A7C", VA = "0x7BBC518A7C", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x0600863B RID: 34363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600863B")]
		[Address(RVA = "0x1D18C30", Offset = "0x1D18C30", VA = "0x7BBC518C30")]
		private void OnToggleMic()
		{
		}

		// Token: 0x0600863C RID: 34364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600863C")]
		[Address(RVA = "0x1D18D40", Offset = "0x1D18D40", VA = "0x7BBC518D40")]
		private void OnToggleSpeaker()
		{
		}

		// Token: 0x0600863D RID: 34365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600863D")]
		[Address(RVA = "0x1D18DFC", Offset = "0x1D18DFC", VA = "0x7BBC518DFC")]
		private void OnVoiceChanged(params object[] data)
		{
		}

		// Token: 0x0600863E RID: 34366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600863E")]
		[Address(RVA = "0x1D18AA4", Offset = "0x1D18AA4", VA = "0x7BBC518AA4")]
		private void RefreshButtonState()
		{
		}

		// Token: 0x0600863F RID: 34367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600863F")]
		[Address(RVA = "0x1D18E00", Offset = "0x1D18E00", VA = "0x7BBC518E00")]
		public UIHudWereWolvesVoiceEngineController()
		{
		}

		// Token: 0x04009573 RID: 38259
		[Token(Token = "0x4009573")]
		[FieldOffset(Offset = "0x58")]
		private UIHudWereWolvesVoiceEngineView m_View;
	}
}
