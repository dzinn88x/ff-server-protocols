using System;
using System.Text;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x02001B97 RID: 7063
	[Token(Token = "0x2001B97")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA724", Offset = "0x10FA724")]
	public class UISPHudRemainingInfoController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06009851 RID: 38993 RVA: 0x00028200 File Offset: 0x00026400
		[Token(Token = "0x6009851")]
		[Address(RVA = "0x1EEEC6C", Offset = "0x1EEEC6C", VA = "0x7BBC6EEC6C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009852 RID: 38994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009852")]
		[Address(RVA = "0x1EEECBC", Offset = "0x1EEECBC", VA = "0x7BBC6EECBC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009853 RID: 38995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009853")]
		[Address(RVA = "0x1EEF468", Offset = "0x1EEF468", VA = "0x7BBC6EF468")]
		private void ChangeVisible(object[] data)
		{
		}

		// Token: 0x06009854 RID: 38996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009854")]
		[Address(RVA = "0x1EEF4F8", Offset = "0x1EEF4F8", VA = "0x7BBC6EF4F8")]
		private void Update()
		{
		}

		// Token: 0x06009855 RID: 38997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009855")]
		[Address(RVA = "0x1EEF6CC", Offset = "0x1EEF6CC", VA = "0x7BBC6EF6CC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009856 RID: 38998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009856")]
		[Address(RVA = "0x1EEF804", Offset = "0x1EEF804", VA = "0x7BBC6EF804", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06009857 RID: 38999 RVA: 0x00028218 File Offset: 0x00026418
		[Token(Token = "0x6009857")]
		[Address(RVA = "0x1EEFA70", Offset = "0x1EEFA70", VA = "0x7BBC6EFA70", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06009858 RID: 39000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009858")]
		[Address(RVA = "0x1EEFAB4", Offset = "0x1EEFAB4", VA = "0x7BBC6EFAB4")]
		private void OnSafeZoneChanged(params object[] data)
		{
		}

		// Token: 0x06009859 RID: 39001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009859")]
		[Address(RVA = "0x1EEFBDC", Offset = "0x1EEFBDC", VA = "0x7BBC6EFBDC")]
		public UISPHudRemainingInfoController()
		{
		}

		// Token: 0x0400A02B RID: 41003
		[Token(Token = "0x400A02B")]
		[FieldOffset(Offset = "0x58")]
		private UISPHudRemainingInfoView m_View;

		// Token: 0x0400A02C RID: 41004
		[Token(Token = "0x400A02C")]
		[FieldOffset(Offset = "0x60")]
		private zTfbhtW m_CurrentGroupMode;

		// Token: 0x0400A02D RID: 41005
		[Token(Token = "0x400A02D")]
		[FieldOffset(Offset = "0x68")]
		private long m_LastSeconds;

		// Token: 0x0400A02E RID: 41006
		[Token(Token = "0x400A02E")]
		[FieldOffset(Offset = "0x70")]
		private StringBuilder m_TimeString;

		// Token: 0x0400A02F RID: 41007
		[Token(Token = "0x400A02F")]
		[FieldOffset(Offset = "0x78")]
		private COWGameBase.GameSubType m_SubGameType;
	}
}
