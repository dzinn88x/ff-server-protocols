using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018FE RID: 6398
	[Token(Token = "0x20018FE")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F55F4", Offset = "0x10F55F4")]
	internal class UIHudKillNotificationController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x0600807B RID: 32891 RVA: 0x00023070 File Offset: 0x00021270
		[Token(Token = "0x600807B")]
		[Address(RVA = "0x1C4EF04", Offset = "0x1C4EF04", VA = "0x7BBC44EF04")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600807C RID: 32892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600807C")]
		[Address(RVA = "0x1C4EF54", Offset = "0x1C4EF54", VA = "0x7BBC44EF54", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600807D RID: 32893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600807D")]
		[Address(RVA = "0x1C4F9D8", Offset = "0x1C4F9D8", VA = "0x7BBC44F9D8", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x0600807E RID: 32894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600807E")]
		[Address(RVA = "0x1C4FC30", Offset = "0x1C4FC30", VA = "0x7BBC44FC30", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600807F RID: 32895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600807F")]
		[Address(RVA = "0x1C4FD70", Offset = "0x1C4FD70", VA = "0x7BBC44FD70")]
		private void Update()
		{
		}

		// Token: 0x06008080 RID: 32896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008080")]
		[Address(RVA = "0x1C50500", Offset = "0x1C50500", VA = "0x7BBC450500")]
		private void OnHypeLevelChanged(params object[] data)
		{
		}

		// Token: 0x06008081 RID: 32897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008081")]
		[Address(RVA = "0x1C50728", Offset = "0x1C50728", VA = "0x7BBC450728", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008082 RID: 32898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008082")]
		[Address(RVA = "0x1C51898", Offset = "0x1C51898", VA = "0x7BBC451898")]
		private void AddPendingNotificationToQueue(PendingNotification notification)
		{
		}

		// Token: 0x06008083 RID: 32899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008083")]
		[Address(RVA = "0x1C5065C", Offset = "0x1C5065C", VA = "0x7BBC45065C")]
		private PendingNotification GetPendingNotificationFromPool()
		{
			return null;
		}

		// Token: 0x06008084 RID: 32900 RVA: 0x00023088 File Offset: 0x00021288
		[Token(Token = "0x6008084")]
		[Address(RVA = "0x1C517FC", Offset = "0x1C517FC", VA = "0x7BBC4517FC")]
		private uint CheckWeaponSkinId(uint skinId)
		{
			return 0U;
		}

		// Token: 0x06008085 RID: 32901 RVA: 0x000230A0 File Offset: 0x000212A0
		[Token(Token = "0x6008085")]
		[Address(RVA = "0x1C51930", Offset = "0x1C51930", VA = "0x7BBC451930", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008086 RID: 32902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008086")]
		[Address(RVA = "0x1C4F680", Offset = "0x1C4F680", VA = "0x7BBC44F680")]
		private void UpdateMiniTips(bool isMini)
		{
		}

		// Token: 0x06008087 RID: 32903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008087")]
		[Address(RVA = "0x1C51A24", Offset = "0x1C51A24", VA = "0x7BBC451A24")]
		private void OnIngameTipsChanged(params object[] data)
		{
		}

		// Token: 0x06008088 RID: 32904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008088")]
		[Address(RVA = "0x1C51AB8", Offset = "0x1C51AB8", VA = "0x7BBC451AB8")]
		public UIHudKillNotificationController()
		{
		}

		// Token: 0x040092A6 RID: 37542
		[Token(Token = "0x40092A6")]
		[FieldOffset(Offset = "0x58")]
		private UIHudKillNotificationView m_View;

		// Token: 0x040092A7 RID: 37543
		[Token(Token = "0x40092A7")]
		[FieldOffset(Offset = "0x60")]
		private UIHudKillNotificationItem[] m_Items;

		// Token: 0x040092A8 RID: 37544
		[Token(Token = "0x40092A8")]
		[FieldOffset(Offset = "0x68")]
		private UIHudKillNotificationItem[] m_MiniItems;

		// Token: 0x040092A9 RID: 37545
		[Token(Token = "0x40092A9")]
		[FieldOffset(Offset = "0x70")]
		private UIWeaponKillNotificationItemController m_WeaponKillNotification;

		// Token: 0x040092AA RID: 37546
		[Token(Token = "0x40092AA")]
		[FieldOffset(Offset = "0x78")]
		private UIModelMatch m_MatchModel;

		// Token: 0x040092AB RID: 37547
		[Token(Token = "0x40092AB")]
		[FieldOffset(Offset = "0x80")]
		private Queue<PendingNotification> m_PendingNotificationRegular;

		// Token: 0x040092AC RID: 37548
		[Token(Token = "0x40092AC")]
		[FieldOffset(Offset = "0x88")]
		private Queue<PendingNotification> m_PendingNotificationWeaponWithSkin;

		// Token: 0x040092AD RID: 37549
		[Token(Token = "0x40092AD")]
		[FieldOffset(Offset = "0x90")]
		private Queue<PendingNotification> m_PendingNotificationPool;

		// Token: 0x040092AE RID: 37550
		[Token(Token = "0x40092AE")]
		[FieldOffset(Offset = "0x98")]
		private Timer m_AddNotificationCoolDown;

		// Token: 0x040092AF RID: 37551
		[Token(Token = "0x40092AF")]
		[FieldOffset(Offset = "0xA0")]
		private Dictionary<ushort, string> m_LevelToTipsLoc;

		// Token: 0x040092B0 RID: 37552
		[Token(Token = "0x40092B0")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_IsMiniTips;

		// Token: 0x040092B1 RID: 37553
		[Token(Token = "0x40092B1")]
		[FieldOffset(Offset = "0xA9")]
		private bool m_TeamColor;
	}
}
