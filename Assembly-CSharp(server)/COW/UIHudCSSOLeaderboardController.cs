using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020014CB RID: 5323
	[Token(Token = "0x20014CB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED954", Offset = "0x10ED954")]
	internal class UIHudCSSOLeaderboardController : UIBaseController
	{
		// Token: 0x06005AB4 RID: 23220 RVA: 0x0001A9D0 File Offset: 0x00018BD0
		[Token(Token = "0x6005AB4")]
		[Address(RVA = "0x19C2F9C", Offset = "0x19C2F9C", VA = "0x7BBC1C2F9C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005AB5 RID: 23221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AB5")]
		[Address(RVA = "0x19C2FEC", Offset = "0x19C2FEC", VA = "0x7BBC1C2FEC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005AB6 RID: 23222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AB6")]
		[Address(RVA = "0x19C3218", Offset = "0x19C3218", VA = "0x7BBC1C3218", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005AB7 RID: 23223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AB7")]
		[Address(RVA = "0x19C32E0", Offset = "0x19C32E0", VA = "0x7BBC1C32E0")]
		public void NewRoundStart()
		{
		}

		// Token: 0x06005AB8 RID: 23224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AB8")]
		[Address(RVA = "0x19C37B0", Offset = "0x19C37B0", VA = "0x7BBC1C37B0")]
		public void ShowLeaderBoard()
		{
		}

		// Token: 0x06005AB9 RID: 23225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AB9")]
		[Address(RVA = "0x19C336C", Offset = "0x19C336C", VA = "0x7BBC1C336C")]
		private void CreateItemCtrl(bool newRoundStart)
		{
		}

		// Token: 0x06005ABA RID: 23226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ABA")]
		[Address(RVA = "0x19C37A4", Offset = "0x19C37A4", VA = "0x7BBC1C37A4")]
		public void RefreshRoundInfo(bool newRoundStart)
		{
		}

		// Token: 0x06005ABB RID: 23227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ABB")]
		[Address(RVA = "0x19C3A48", Offset = "0x19C3A48", VA = "0x7BBC1C3A48")]
		private void ShowNewRoundStart()
		{
		}

		// Token: 0x06005ABC RID: 23228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ABC")]
		[Address(RVA = "0x19C3E74", Offset = "0x19C3E74", VA = "0x7BBC1C3E74")]
		private void ShowCurrRoundInfo()
		{
		}

		// Token: 0x06005ABD RID: 23229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ABD")]
		[Address(RVA = "0x19C3240", Offset = "0x19C3240", VA = "0x7BBC1C3240")]
		private void CancelDelayCall()
		{
		}

		// Token: 0x06005ABE RID: 23230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ABE")]
		[Address(RVA = "0x19C403C", Offset = "0x19C403C", VA = "0x7BBC1C403C")]
		public UIHudCSSOLeaderboardController()
		{
		}

		// Token: 0x04007D86 RID: 32134
		[Token(Token = "0x4007D86")]
		[FieldOffset(Offset = "0x58")]
		private UIHudCSSOLeaderboardView m_View;

		// Token: 0x04007D87 RID: 32135
		[Token(Token = "0x4007D87")]
		[FieldOffset(Offset = "0x60")]
		private BmPqYDk m_Game;

		// Token: 0x04007D88 RID: 32136
		[Token(Token = "0x4007D88")]
		[FieldOffset(Offset = "0x68")]
		private uint m_DelayCallID;

		// Token: 0x04007D89 RID: 32137
		[Token(Token = "0x4007D89")]
		[FieldOffset(Offset = "0x70")]
		private UIModelMatch m_ModelMatch;

		// Token: 0x04007D8A RID: 32138
		[Token(Token = "0x4007D8A")]
		private const string DELAYTIMEKEY = "({0}s)";

		// Token: 0x04007D8B RID: 32139
		[Token(Token = "0x4007D8B")]
		[FieldOffset(Offset = "0x78")]
		private int m_CurrRound;

		// Token: 0x020014CC RID: 5324
		[Token(Token = "0x20014CC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10ED98C", Offset = "0x10ED98C")]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06005ABF RID: 23231 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005ABF")]
			[Address(RVA = "0x19C4034", Offset = "0x19C4034", VA = "0x7BBC1C4034")]
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x06005AC0 RID: 23232 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005AC0")]
			[Address(RVA = "0x19C4044", Offset = "0x19C4044", VA = "0x7BBC1C4044")]
			internal void <ShowNewRoundStart>b__0()
			{
			}

			// Token: 0x04007D8C RID: 32140
			[Token(Token = "0x4007D8C")]
			[FieldOffset(Offset = "0x10")]
			public int delayTime;

			// Token: 0x04007D8D RID: 32141
			[Token(Token = "0x4007D8D")]
			[FieldOffset(Offset = "0x18")]
			public UIHudCSSOLeaderboardController <>4__this;

			// Token: 0x04007D8E RID: 32142
			[Token(Token = "0x4007D8E")]
			[FieldOffset(Offset = "0x20")]
			public int phaseEndTime;
		}
	}
}
