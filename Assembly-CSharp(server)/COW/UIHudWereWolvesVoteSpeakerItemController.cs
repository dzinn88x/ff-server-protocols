using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020019A9 RID: 6569
	[Token(Token = "0x20019A9")]
	public class UIHudWereWolvesVoteSpeakerItemController : UIEasyListItemController
	{
		// Token: 0x06008687 RID: 34439 RVA: 0x00024690 File Offset: 0x00022890
		[Token(Token = "0x6008687")]
		[Address(RVA = "0x1D1F7D0", Offset = "0x1D1F7D0", VA = "0x7BBC51F7D0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008688 RID: 34440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008688")]
		[Address(RVA = "0x1D1F820", Offset = "0x1D1F820", VA = "0x7BBC51F820", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008689 RID: 34441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008689")]
		[Address(RVA = "0x1D1F980", Offset = "0x1D1F980", VA = "0x7BBC51F980", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600868A RID: 34442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600868A")]
		[Address(RVA = "0x1D1FA4C", Offset = "0x1D1FA4C", VA = "0x7BBC51FA4C", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x0600868B RID: 34443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600868B")]
		[Address(RVA = "0x1D1FE60", Offset = "0x1D1FE60", VA = "0x7BBC51FE60")]
		private void OnSpeakerClick()
		{
		}

		// Token: 0x0600868C RID: 34444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600868C")]
		[Address(RVA = "0x1D1FD74", Offset = "0x1D1FD74", VA = "0x7BBC51FD74")]
		private void RefreshSpeaker()
		{
		}

		// Token: 0x0600868D RID: 34445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600868D")]
		[Address(RVA = "0x1D20130", Offset = "0x1D20130", VA = "0x7BBC520130")]
		private void OnMuteStateChange(params object[] data)
		{
		}

		// Token: 0x0600868E RID: 34446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600868E")]
		[Address(RVA = "0x1D202B8", Offset = "0x1D202B8", VA = "0x7BBC5202B8")]
		public UIHudWereWolvesVoteSpeakerItemController()
		{
		}

		// Token: 0x04009590 RID: 38288
		[Token(Token = "0x4009590")]
		[FieldOffset(Offset = "0x70")]
		private UIHudWereWolvesVoteSpeakerItemView m_View;

		// Token: 0x04009591 RID: 38289
		[Token(Token = "0x4009591")]
		[FieldOffset(Offset = "0x78")]
		private {QAb\u0082~u m_PlayerId;

		// Token: 0x04009592 RID: 38290
		[Token(Token = "0x4009592")]
		[FieldOffset(Offset = "0x90")]
		private ulong m_UserId;
	}
}
