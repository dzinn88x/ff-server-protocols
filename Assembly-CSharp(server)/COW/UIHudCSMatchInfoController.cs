using System;
using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020014BB RID: 5307
	[Token(Token = "0x20014BB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED704", Offset = "0x10ED704")]
	internal class UIHudCSMatchInfoController : UIBaseController
	{
		// Token: 0x06005A2C RID: 23084 RVA: 0x0001A898 File Offset: 0x00018A98
		[Token(Token = "0x6005A2C")]
		[Address(RVA = "0x19BEB24", Offset = "0x19BEB24", VA = "0x7BBC1BEB24")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005A2D RID: 23085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A2D")]
		[Address(RVA = "0x19BEB74", Offset = "0x19BEB74", VA = "0x7BBC1BEB74", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005A2E RID: 23086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A2E")]
		[Address(RVA = "0x19BF16C", Offset = "0x19BF16C", VA = "0x7BBC1BF16C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005A2F RID: 23087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A2F")]
		[Address(RVA = "0x19BF51C", Offset = "0x19BF51C", VA = "0x7BBC1BF51C", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06005A30 RID: 23088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A30")]
		[Address(RVA = "0x19BF5E0", Offset = "0x19BF5E0", VA = "0x7BBC1BF5E0")]
		private void OnBtnLeaderboardClick()
		{
		}

		// Token: 0x06005A31 RID: 23089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A31")]
		[Address(RVA = "0x19BF554", Offset = "0x19BF554", VA = "0x7BBC1BF554")]
		private void SetUIData()
		{
		}

		// Token: 0x06005A32 RID: 23090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A32")]
		[Address(RVA = "0x19BFBC0", Offset = "0x19BFBC0", VA = "0x7BBC1BFBC0")]
		private void RefreshTeamStatesUI({QAb\u0082~u pId)
		{
		}

		// Token: 0x06005A33 RID: 23091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A33")]
		[Address(RVA = "0x19BF7FC", Offset = "0x19BF7FC", VA = "0x7BBC1BF7FC")]
		private void SetTeamStatesUI(List<{QAb\u0082~u> pids, List<UIHudCSPlayerStateInfoView> views, bool ascending = true)
		{
		}

		// Token: 0x06005A34 RID: 23092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A34")]
		[Address(RVA = "0x19BFED0", Offset = "0x19BFED0", VA = "0x7BBC1BFED0")]
		private void Update()
		{
		}

		// Token: 0x06005A35 RID: 23093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A35")]
		[Address(RVA = "0x19C02B4", Offset = "0x19C02B4", VA = "0x7BBC1C02B4")]
		private void OnPlayerHPChanged(params object[] data)
		{
		}

		// Token: 0x06005A36 RID: 23094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A36")]
		[Address(RVA = "0x19C0394", Offset = "0x19C0394", VA = "0x7BBC1C0394")]
		private void OnPlayerStateChanged(params object[] data)
		{
		}

		// Token: 0x06005A37 RID: 23095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A37")]
		[Address(RVA = "0x19C043C", Offset = "0x19C043C", VA = "0x7BBC1C043C")]
		private void OnPlayerQuit(params object[] data)
		{
		}

		// Token: 0x06005A38 RID: 23096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A38")]
		[Address(RVA = "0x19C0518", Offset = "0x19C0518", VA = "0x7BBC1C0518")]
		private void OnScoreChanged(params object[] data)
		{
		}

		// Token: 0x06005A39 RID: 23097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A39")]
		[Address(RVA = "0x19C0758", Offset = "0x19C0758", VA = "0x7BBC1C0758")]
		private void OnNewPhaseEnter(params object[] data)
		{
		}

		// Token: 0x06005A3A RID: 23098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A3A")]
		[Address(RVA = "0x19C0888", Offset = "0x19C0888", VA = "0x7BBC1C0888")]
		private void OnStartMatchEndShow(object[] data)
		{
		}

		// Token: 0x06005A3B RID: 23099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A3B")]
		[Address(RVA = "0x19BF6C0", Offset = "0x19BF6C0", VA = "0x7BBC1BF6C0")]
		private void SetRoundInfoUI()
		{
		}

		// Token: 0x06005A3C RID: 23100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A3C")]
		[Address(RVA = "0x19C0890", Offset = "0x19C0890", VA = "0x7BBC1C0890")]
		public UIHudCSMatchInfoController()
		{
		}

		// Token: 0x06005A3D RID: 23101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A3D")]
		[Address(RVA = "0x19C0920", Offset = "0x19C0920", VA = "0x7BBC1C0920")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F528", Offset = "0x113F528")]
		private void <OnNewPhaseEnter>b__25_0()
		{
		}

		// Token: 0x04007D41 RID: 32065
		[Token(Token = "0x4007D41")]
		[FieldOffset(Offset = "0x58")]
		private UIHudCSMatchInfoView m_View;

		// Token: 0x04007D42 RID: 32066
		[Token(Token = "0x4007D42")]
		[FieldOffset(Offset = "0x60")]
		private int mSeconds;

		// Token: 0x04007D43 RID: 32067
		[Token(Token = "0x4007D43")]
		[FieldOffset(Offset = "0x68")]
		private StringBuilder m_Timer;

		// Token: 0x04007D44 RID: 32068
		[Token(Token = "0x4007D44")]
		[FieldOffset(Offset = "0x70")]
		private uint min;

		// Token: 0x04007D45 RID: 32069
		[Token(Token = "0x4007D45")]
		[FieldOffset(Offset = "0x74")]
		private uint sec;

		// Token: 0x04007D46 RID: 32070
		[Token(Token = "0x4007D46")]
		[FieldOffset(Offset = "0x78")]
		private List<UIHudCSPlayerStateInfoView> m_MyTeamViews;

		// Token: 0x04007D47 RID: 32071
		[Token(Token = "0x4007D47")]
		[FieldOffset(Offset = "0x80")]
		private List<UIHudCSPlayerStateInfoView> m_OppoTeamViews;

		// Token: 0x04007D48 RID: 32072
		[Token(Token = "0x4007D48")]
		[FieldOffset(Offset = "0x88")]
		private ZCvdc^^ mGame;

		// Token: 0x04007D49 RID: 32073
		[Token(Token = "0x4007D49")]
		[FieldOffset(Offset = "0x90")]
		private uint m_TutorialLeadboardDelayCall;

		// Token: 0x04007D4A RID: 32074
		[Token(Token = "0x4007D4A")]
		[FieldOffset(Offset = "0x98")]
		private UIModelMatch m_ModelMatch;

		// Token: 0x04007D4B RID: 32075
		[Token(Token = "0x4007D4B")]
		private const uint TEAMCOUNT = 4U;

		// Token: 0x020014BC RID: 5308
		[Token(Token = "0x20014BC")]
		private struct CSPlayerState
		{
			// Token: 0x04007D4C RID: 32076
			[Token(Token = "0x4007D4C")]
			[FieldOffset(Offset = "0x0")]
			public UIHudCSPlayerStateInfoView view;

			// Token: 0x04007D4D RID: 32077
			[Token(Token = "0x4007D4D")]
			[FieldOffset(Offset = "0x8")]
			public ETeammateState state;
		}
	}
}
