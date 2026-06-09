using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001373 RID: 4979
	[Token(Token = "0x2001373")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB560", Offset = "0x10EB560")]
	public class UIFFWSTurntableSignInItemController : UIBaseController
	{
		// Token: 0x06004FE2 RID: 20450 RVA: 0x000184C8 File Offset: 0x000166C8
		[Token(Token = "0x6004FE2")]
		[Address(RVA = "0x1DAFC98", Offset = "0x1DAFC98", VA = "0x7BBC5AFC98")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06004FE3 RID: 20451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FE3")]
		[Address(RVA = "0x1DAFCE8", Offset = "0x1DAFCE8", VA = "0x7BBC5AFCE8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06004FE4 RID: 20452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FE4")]
		[Address(RVA = "0x1DADFF0", Offset = "0x1DADFF0", VA = "0x7BBC5ADFF0")]
		public void SetData(AttendanceItem info)
		{
		}

		// Token: 0x06004FE5 RID: 20453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FE5")]
		[Address(RVA = "0x1DB0240", Offset = "0x1DB0240", VA = "0x7BBC5B0240")]
		private void SetQualityBG()
		{
		}

		// Token: 0x06004FE6 RID: 20454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FE6")]
		[Address(RVA = "0x1DAFEA4", Offset = "0x1DAFEA4", VA = "0x7BBC5AFEA4")]
		private void RefreshSignState()
		{
		}

		// Token: 0x06004FE7 RID: 20455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FE7")]
		[Address(RVA = "0x1DB0518", Offset = "0x1DB0518", VA = "0x7BBC5B0518")]
		private void ShowBigRewardEffect()
		{
		}

		// Token: 0x06004FE8 RID: 20456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FE8")]
		[Address(RVA = "0x1DB05E0", Offset = "0x1DB05E0", VA = "0x7BBC5B05E0")]
		private void OnItemBtnClick()
		{
		}

		// Token: 0x06004FE9 RID: 20457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FE9")]
		[Address(RVA = "0x1DAF4D8", Offset = "0x1DAF4D8", VA = "0x7BBC5AF4D8")]
		public void ShowView(UIFFWSTurntableSignInItemController.ViewStage stage, float alpha = 1f)
		{
		}

		// Token: 0x06004FEA RID: 20458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FEA")]
		[Address(RVA = "0x1DB07F0", Offset = "0x1DB07F0", VA = "0x7BBC5B07F0")]
		private void PlaySelectedAudio()
		{
		}

		// Token: 0x06004FEB RID: 20459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FEB")]
		[Address(RVA = "0x1DB088C", Offset = "0x1DB088C", VA = "0x7BBC5B088C")]
		private void PlayGetRewardAudio()
		{
		}

		// Token: 0x06004FEC RID: 20460 RVA: 0x000184E0 File Offset: 0x000166E0
		[Token(Token = "0x6004FEC")]
		[Address(RVA = "0x1DAF7DC", Offset = "0x1DAF7DC", VA = "0x7BBC5AF7DC")]
		public bool isOwnedorRemoved()
		{
			return default(bool);
		}

		// Token: 0x06004FED RID: 20461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FED")]
		[Address(RVA = "0x1DB0928", Offset = "0x1DB0928", VA = "0x7BBC5B0928")]
		public UIFFWSTurntableSignInItemController()
		{
		}

		// Token: 0x04007673 RID: 30323
		[Token(Token = "0x4007673")]
		[FieldOffset(Offset = "0x58")]
		private UIFFWSTurntableSignInItemView m_View;

		// Token: 0x04007674 RID: 30324
		[Token(Token = "0x4007674")]
		[FieldOffset(Offset = "0x60")]
		private AttendanceItem m_ItemInfo;

		// Token: 0x04007675 RID: 30325
		[Token(Token = "0x4007675")]
		[FieldOffset(Offset = "0x68")]
		private BaseItemInfo m_BaseItemInfo;

		// Token: 0x04007676 RID: 30326
		[Token(Token = "0x4007676")]
		private const uint CLAIMEDCOLOR = 1886417151U;

		// Token: 0x04007677 RID: 30327
		[Token(Token = "0x4007677")]
		[FieldOffset(Offset = "0x70")]
		private UIFFWSTurntableSignInItemController.TurnTableItemState m_CurrentState;

		// Token: 0x02001374 RID: 4980
		[Token(Token = "0x2001374")]
		public enum ViewStage
		{
			// Token: 0x04007679 RID: 30329
			[Token(Token = "0x4007679")]
			NORMAL,
			// Token: 0x0400767A RID: 30330
			[Token(Token = "0x400767A")]
			SELECTED,
			// Token: 0x0400767B RID: 30331
			[Token(Token = "0x400767B")]
			GET_REWARD
		}

		// Token: 0x02001375 RID: 4981
		[Token(Token = "0x2001375")]
		private enum TurnTableItemState
		{
			// Token: 0x0400767D RID: 30333
			[Token(Token = "0x400767D")]
			Normal,
			// Token: 0x0400767E RID: 30334
			[Token(Token = "0x400767E")]
			Remove,
			// Token: 0x0400767F RID: 30335
			[Token(Token = "0x400767F")]
			Owned
		}
	}
}
