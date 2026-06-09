using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020016EE RID: 5870
	[Token(Token = "0x20016EE")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F10DC", Offset = "0x10F10DC")]
	public class UIBroadcastController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06006CE0 RID: 27872 RVA: 0x0001EB58 File Offset: 0x0001CD58
		[Token(Token = "0x6006CE0")]
		[Address(RVA = "0x1C1C5B8", Offset = "0x1C1C5B8", VA = "0x7BBC41C5B8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006CE1 RID: 27873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CE1")]
		[Address(RVA = "0x1C1C608", Offset = "0x1C1C608", VA = "0x7BBC41C608", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006CE2 RID: 27874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CE2")]
		[Address(RVA = "0x1C1C880", Offset = "0x1C1C880", VA = "0x7BBC41C880", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06006CE3 RID: 27875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CE3")]
		[Address(RVA = "0x1C1CA14", Offset = "0x1C1CA14", VA = "0x7BBC41CA14")]
		private void OnNoticeClick()
		{
		}

		// Token: 0x06006CE4 RID: 27876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CE4")]
		[Address(RVA = "0x1C1CA54", Offset = "0x1C1CA54", VA = "0x7BBC41CA54")]
		private void OnCloseBroadCast(object[] data)
		{
		}

		// Token: 0x06006CE5 RID: 27877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CE5")]
		[Address(RVA = "0x1C1CAB0", Offset = "0x1C1CAB0", VA = "0x7BBC41CAB0", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006CE6 RID: 27878 RVA: 0x0001EB70 File Offset: 0x0001CD70
		[Token(Token = "0x6006CE6")]
		[Address(RVA = "0x1C1CDB8", Offset = "0x1C1CDB8", VA = "0x7BBC41CDB8", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006CE7 RID: 27879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CE7")]
		[Address(RVA = "0x1C1CDFC", Offset = "0x1C1CDFC", VA = "0x7BBC41CDFC")]
		public UIBroadcastController()
		{
		}

		// Token: 0x06006CE8 RID: 27880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CE8")]
		[Address(RVA = "0x1C1CE04", Offset = "0x1C1CE04", VA = "0x7BBC41CE04")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11412DC", Offset = "0x11412DC")]
		private void <OnUIInit>b__3_0()
		{
		}

		// Token: 0x04008855 RID: 34901
		[Token(Token = "0x4008855")]
		[FieldOffset(Offset = "0x58")]
		private UIBroadcastView m_View;

		// Token: 0x04008856 RID: 34902
		[Token(Token = "0x4008856")]
		[FieldOffset(Offset = "0x60")]
		private uint m_DelayCallId;
	}
}
