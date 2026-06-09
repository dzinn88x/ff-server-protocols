using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020014C6 RID: 5318
	[Token(Token = "0x20014C6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED864", Offset = "0x10ED864")]
	internal class UIHudLeaderboardController : UIBaseController
	{
		// Token: 0x06005A78 RID: 23160 RVA: 0x0001A940 File Offset: 0x00018B40
		[Token(Token = "0x6005A78")]
		[Address(RVA = "0x15B801C", Offset = "0x15B801C", VA = "0x7BBBDB801C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005A79 RID: 23161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A79")]
		[Address(RVA = "0x15B806C", Offset = "0x15B806C", VA = "0x7BBBDB806C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005A7A RID: 23162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A7A")]
		[Address(RVA = "0x15B8430", Offset = "0x15B8430", VA = "0x7BBBDB8430", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005A7B RID: 23163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A7B")]
		[Address(RVA = "0x15B8748", Offset = "0x15B8748", VA = "0x7BBBDB8748")]
		private void OnBtnCloseClick()
		{
		}

		// Token: 0x06005A7C RID: 23164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A7C")]
		[Address(RVA = "0x15B8758", Offset = "0x15B8758", VA = "0x7BBBDB8758")]
		private void OnAddPlayer(params object[] param)
		{
		}

		// Token: 0x06005A7D RID: 23165 RVA: 0x0001A958 File Offset: 0x00018B58
		[Token(Token = "0x6005A7D")]
		[Address(RVA = "0x15B90FC", Offset = "0x15B90FC", VA = "0x7BBBDB90FC")]
		private bool IsTeamOnLeft({QAb\u0082~u pId)
		{
			return default(bool);
		}

		// Token: 0x06005A7E RID: 23166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A7E")]
		[Address(RVA = "0x15B8DAC", Offset = "0x15B8DAC", VA = "0x7BBBDB8DAC")]
		private void AddItemController({QAb\u0082~u pId, LeaderboardData dataInfo)
		{
		}

		// Token: 0x06005A7F RID: 23167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A7F")]
		[Address(RVA = "0x15B97C4", Offset = "0x15B97C4", VA = "0x7BBBDB97C4")]
		private void Sort({QAb\u0082~u pId)
		{
		}

		// Token: 0x06005A80 RID: 23168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A80")]
		[Address(RVA = "0x15B9918", Offset = "0x15B9918", VA = "0x7BBBDB9918")]
		private void OnKillCountChanged(params object[] param)
		{
		}

		// Token: 0x06005A81 RID: 23169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A81")]
		[Address(RVA = "0x15B9AF0", Offset = "0x15B9AF0", VA = "0x7BBBDB9AF0")]
		private void OnDeadCountChanged(params object[] param)
		{
		}

		// Token: 0x06005A82 RID: 23170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A82")]
		[Address(RVA = "0x15B9CC8", Offset = "0x15B9CC8", VA = "0x7BBBDB9CC8")]
		private void OnAssistCountChanged(params object[] param)
		{
		}

		// Token: 0x06005A83 RID: 23171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A83")]
		[Address(RVA = "0x15B9EA0", Offset = "0x15B9EA0", VA = "0x7BBBDB9EA0")]
		private void OnTotalDamageChanged(params object[] param)
		{
		}

		// Token: 0x06005A84 RID: 23172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A84")]
		[Address(RVA = "0x15BA078", Offset = "0x15BA078", VA = "0x7BBBDBA078")]
		private void OnCSNewPhaseStarted(params object[] param)
		{
		}

		// Token: 0x06005A85 RID: 23173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A85")]
		[Address(RVA = "0x15BA12C", Offset = "0x15BA12C", VA = "0x7BBBDBA12C")]
		private void OnFactionIDChanged(params object[] param)
		{
		}

		// Token: 0x06005A86 RID: 23174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A86")]
		[Address(RVA = "0x15B93EC", Offset = "0x15B93EC", VA = "0x7BBBDB93EC")]
		private void UpdateFactionInfo()
		{
		}

		// Token: 0x06005A87 RID: 23175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A87")]
		[Address(RVA = "0x15B9228", Offset = "0x15B9228", VA = "0x7BBBDB9228")]
		private void UpdateFactionInfo(int localFactionID)
		{
		}

		// Token: 0x06005A88 RID: 23176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A88")]
		[Address(RVA = "0x15BA1CC", Offset = "0x15BA1CC", VA = "0x7BBBDBA1CC")]
		private void OnToggleRoundInfo(params object[] parap)
		{
		}

		// Token: 0x06005A89 RID: 23177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A89")]
		[Address(RVA = "0x15BA228", Offset = "0x15BA228", VA = "0x7BBBDBA228", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06005A8A RID: 23178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A8A")]
		[Address(RVA = "0x15BA2C4", Offset = "0x15BA2C4", VA = "0x7BBBDBA2C4")]
		public UIHudLeaderboardController()
		{
		}

		// Token: 0x04007D72 RID: 32114
		[Token(Token = "0x4007D72")]
		[FieldOffset(Offset = "0x58")]
		private UIHudLeaderboardView m_View;

		// Token: 0x04007D73 RID: 32115
		[Token(Token = "0x4007D73")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<{QAb\u0082~u, LeaderboardData> m_ItemsBe4LocalPlayer;

		// Token: 0x04007D74 RID: 32116
		[Token(Token = "0x4007D74")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<{QAb\u0082~u, UIHudLeaderboardItemController> m_ItemControllers;

		// Token: 0x04007D75 RID: 32117
		[Token(Token = "0x4007D75")]
		[FieldOffset(Offset = "0x70")]
		private bool m_LocalPlayerAdded;

		// Token: 0x04007D76 RID: 32118
		[Token(Token = "0x4007D76")]
		[FieldOffset(Offset = "0x74")]
		private int m_LocalPlayerTeamId;

		// Token: 0x04007D77 RID: 32119
		[Token(Token = "0x4007D77")]
		[FieldOffset(Offset = "0x78")]
		private bool m_IsSPFactionUpdated;

		// Token: 0x020014C7 RID: 5319
		[Token(Token = "0x20014C7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10ED89C", Offset = "0x10ED89C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005A8C RID: 23180 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005A8C")]
			[Address(RVA = "0x15BA3C0", Offset = "0x15BA3C0", VA = "0x7BBBDBA3C0")]
			public <>c()
			{
			}

			// Token: 0x06005A8D RID: 23181 RVA: 0x0001A970 File Offset: 0x00018B70
			[Token(Token = "0x6005A8D")]
			[Address(RVA = "0x15BA3C8", Offset = "0x15BA3C8", VA = "0x7BBBDBA3C8")]
			internal int <Sort>b__13_0(Transform item2, Transform item1)
			{
				return 0;
			}

			// Token: 0x04007D78 RID: 32120
			[Token(Token = "0x4007D78")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIHudLeaderboardController.<>c <>9;

			// Token: 0x04007D79 RID: 32121
			[Token(Token = "0x4007D79")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<Transform> <>9__13_0;
		}
	}
}
