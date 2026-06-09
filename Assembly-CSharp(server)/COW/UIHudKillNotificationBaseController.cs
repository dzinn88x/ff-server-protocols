using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018FD RID: 6397
	[Token(Token = "0x20018FD")]
	internal abstract class UIHudKillNotificationBaseController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06008072 RID: 32882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008072")]
		[Address(RVA = "0x1C4E9F0", Offset = "0x1C4E9F0", VA = "0x7BBC44E9F0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008073 RID: 32883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008073")]
		[Address(RVA = "0x1C4EAA8", Offset = "0x1C4EAA8", VA = "0x7BBC44EAA8", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008074 RID: 32884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008074")]
		[Address(RVA = "0x1C4EAE8", Offset = "0x1C4EAE8", VA = "0x7BBC44EAE8", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06008075 RID: 32885 RVA: 0x00023058 File Offset: 0x00021258
		[Token(Token = "0x6008075")]
		[Address(RVA = "0x1C4EB1C", Offset = "0x1C4EB1C", VA = "0x7BBC44EB1C", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008076 RID: 32886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008076")]
		[Address(RVA = "0x1C4EB60", Offset = "0x1C4EB60", VA = "0x7BBC44EB60", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008077 RID: 32887
		[Token(Token = "0x6008077")]
		protected abstract void OnKill(Player killer, Player beKiller, params object[] param);

		// Token: 0x06008078 RID: 32888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008078")]
		[Address(RVA = "0x1C4EDAC", Offset = "0x1C4EDAC", VA = "0x7BBC44EDAC")]
		protected void Show(float secs)
		{
		}

		// Token: 0x06008079 RID: 32889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008079")]
		[Address(RVA = "0x1C4EEE8", Offset = "0x1C4EEE8", VA = "0x7BBC44EEE8")]
		protected void WaitAndHide()
		{
		}

		// Token: 0x0600807A RID: 32890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600807A")]
		[Address(RVA = "0x1C4EEFC", Offset = "0x1C4EEFC", VA = "0x7BBC44EEFC")]
		protected UIHudKillNotificationBaseController()
		{
		}

		// Token: 0x040092A4 RID: 37540
		[Token(Token = "0x40092A4")]
		[FieldOffset(Offset = "0x58")]
		protected UIModelMatch m_Model;

		// Token: 0x040092A5 RID: 37541
		[Token(Token = "0x40092A5")]
		[FieldOffset(Offset = "0x60")]
		private uint m_DelayCallID;
	}
}
