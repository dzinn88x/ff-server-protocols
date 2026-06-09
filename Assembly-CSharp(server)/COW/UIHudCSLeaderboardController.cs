using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020014B8 RID: 5304
	[Token(Token = "0x20014B8")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED684", Offset = "0x10ED684")]
	internal class UIHudCSLeaderboardController : UIHUDTeamBattleScoreBoardController<UIHudCSLeaderboardItemController>
	{
		// Token: 0x06005A11 RID: 23057 RVA: 0x0001A838 File Offset: 0x00018A38
		[Token(Token = "0x6005A11")]
		[Address(RVA = "0x19BD554", Offset = "0x19BD554", VA = "0x7BBC1BD554")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005A12 RID: 23058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A12")]
		[Address(RVA = "0x19BD5A4", Offset = "0x19BD5A4", VA = "0x7BBC1BD5A4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005A13 RID: 23059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A13")]
		[Address(RVA = "0x19BD624", Offset = "0x19BD624", VA = "0x7BBC1BD624", Slot = "28")]
		protected override void SetInfoType()
		{
		}

		// Token: 0x06005A14 RID: 23060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A14")]
		[Address(RVA = "0x19BD71C", Offset = "0x19BD71C", VA = "0x7BBC1BD71C", Slot = "30")]
		public override void RegisterUIEvent()
		{
		}

		// Token: 0x06005A15 RID: 23061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A15")]
		[Address(RVA = "0x19BD998", Offset = "0x19BD998", VA = "0x7BBC1BD998", Slot = "31")]
		public override void UnRegisterUIEvent()
		{
		}

		// Token: 0x06005A16 RID: 23062 RVA: 0x0001A850 File Offset: 0x00018A50
		[Token(Token = "0x6005A16")]
		[Address(RVA = "0x19BDC14", Offset = "0x19BDC14", VA = "0x7BBC1BDC14", Slot = "34")]
		protected override bool IsTeamOnLeft({QAb\u0082~u pId)
		{
			return default(bool);
		}

		// Token: 0x06005A17 RID: 23063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A17")]
		[Address(RVA = "0x19BDD40", Offset = "0x19BDD40", VA = "0x7BBC1BDD40")]
		private void Sort({QAb\u0082~u pId)
		{
		}

		// Token: 0x06005A18 RID: 23064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A18")]
		[Address(RVA = "0x19BDEB0", Offset = "0x19BDEB0", VA = "0x7BBC1BDEB0", Slot = "37")]
		protected override void OnKillCountChanged(params object[] param)
		{
		}

		// Token: 0x06005A19 RID: 23065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A19")]
		[Address(RVA = "0x19BDF7C", Offset = "0x19BDF7C", VA = "0x7BBC1BDF7C", Slot = "38")]
		protected override void OnDeadCountChanged(params object[] param)
		{
		}

		// Token: 0x06005A1A RID: 23066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A1A")]
		[Address(RVA = "0x19BE048", Offset = "0x19BE048", VA = "0x7BBC1BE048", Slot = "39")]
		protected override void OnTotalDamageChanged(params object[] param)
		{
		}

		// Token: 0x06005A1B RID: 23067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A1B")]
		[Address(RVA = "0x19BE114", Offset = "0x19BE114", VA = "0x7BBC1BE114")]
		private void OnCSNewPhaseStarted(params object[] param)
		{
		}

		// Token: 0x06005A1C RID: 23068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A1C")]
		[Address(RVA = "0x19BE1C8", Offset = "0x19BE1C8", VA = "0x7BBC1BE1C8")]
		private void OnToggleRoundInfo(params object[] parap)
		{
		}

		// Token: 0x06005A1D RID: 23069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A1D")]
		[Address(RVA = "0x19BE224", Offset = "0x19BE224", VA = "0x7BBC1BE224", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06005A1E RID: 23070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A1E")]
		[Address(RVA = "0x19BE2C0", Offset = "0x19BE2C0", VA = "0x7BBC1BE2C0")]
		private void OnTeamScoreChange(params object[] data)
		{
		}

		// Token: 0x06005A1F RID: 23071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A1F")]
		[Address(RVA = "0x19BE4F4", Offset = "0x19BE4F4", VA = "0x7BBC1BE4F4")]
		public UIHudCSLeaderboardController()
		{
		}

		// Token: 0x020014B9 RID: 5305
		[Token(Token = "0x20014B9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10ED6BC", Offset = "0x10ED6BC")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005A21 RID: 23073 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005A21")]
			[Address(RVA = "0x19BE5A8", Offset = "0x19BE5A8", VA = "0x7BBC1BE5A8")]
			public <>c()
			{
			}

			// Token: 0x06005A22 RID: 23074 RVA: 0x0001A868 File Offset: 0x00018A68
			[Token(Token = "0x6005A22")]
			[Address(RVA = "0x19BE5B0", Offset = "0x19BE5B0", VA = "0x7BBC1BE5B0")]
			internal int <Sort>b__6_0(Transform item2, Transform item1)
			{
				return 0;
			}

			// Token: 0x04007D3E RID: 32062
			[Token(Token = "0x4007D3E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIHudCSLeaderboardController.<>c <>9;

			// Token: 0x04007D3F RID: 32063
			[Token(Token = "0x4007D3F")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<Transform> <>9__6_0;
		}
	}
}
