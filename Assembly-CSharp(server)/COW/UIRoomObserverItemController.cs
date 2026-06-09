using System;
using GCommon;
using Il2CppDummyDll;
using tcp;
using UnityEngine;

namespace COW
{
	// Token: 0x02001B6B RID: 7019
	[Token(Token = "0x2001B6B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F9FEC", Offset = "0x10F9FEC")]
	public class UIRoomObserverItemController : UIBaseController
	{
		// Token: 0x06009719 RID: 38681 RVA: 0x00027E10 File Offset: 0x00026010
		[Token(Token = "0x6009719")]
		[Address(RVA = "0x1A1D0AC", Offset = "0x1A1D0AC", VA = "0x7BBC21D0AC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600971A RID: 38682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600971A")]
		[Address(RVA = "0x1A1D0FC", Offset = "0x1A1D0FC", VA = "0x7BBC21D0FC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600971B RID: 38683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600971B")]
		[Address(RVA = "0x1A1D238", Offset = "0x1A1D238", VA = "0x7BBC21D238")]
		private void OnItemClick()
		{
		}

		// Token: 0x0600971C RID: 38684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600971C")]
		[Address(RVA = "0x1A1D7E0", Offset = "0x1A1D7E0", VA = "0x7BBC21D7E0")]
		private void OnGotoSeat(object data)
		{
		}

		// Token: 0x0600971D RID: 38685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600971D")]
		[Address(RVA = "0x1A1D8B4", Offset = "0x1A1D8B4", VA = "0x7BBC21D8B4")]
		public void SetUIData(RoomPlayerInfo info, int id)
		{
		}

		// Token: 0x0600971E RID: 38686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600971E")]
		[Address(RVA = "0x1A1DD8C", Offset = "0x1A1DD8C", VA = "0x7BBC21DD8C")]
		public void SetEmptyUIData()
		{
		}

		// Token: 0x0600971F RID: 38687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600971F")]
		[Address(RVA = "0x1A1DF50", Offset = "0x1A1DF50", VA = "0x7BBC21DF50")]
		public RoomPlayerInfo ConstructPlayerInfo()
		{
			return null;
		}

		// Token: 0x06009720 RID: 38688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009720")]
		[Address(RVA = "0x1A1E030", Offset = "0x1A1E030", VA = "0x7BBC21E030")]
		public UIRoomObserverItemController()
		{
		}

		// Token: 0x06009722 RID: 38690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009722")]
		[Address(RVA = "0x1A1E0BC", Offset = "0x1A1E0BC", VA = "0x7BBC21E0BC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144D90", Offset = "0x1144D90")]
		private void <OnItemClick>b__9_0()
		{
		}

		// Token: 0x04009F5B RID: 40795
		[Token(Token = "0x4009F5B")]
		[FieldOffset(Offset = "0x0")]
		private static Color NAME_NORMAL;

		// Token: 0x04009F5C RID: 40796
		[Token(Token = "0x4009F5C")]
		[FieldOffset(Offset = "0x10")]
		private static Color NAME_WARNING;

		// Token: 0x04009F5D RID: 40797
		[Token(Token = "0x4009F5D")]
		[FieldOffset(Offset = "0x58")]
		private UIWidget m_ItemWidget;

		// Token: 0x04009F5E RID: 40798
		[Token(Token = "0x4009F5E")]
		[FieldOffset(Offset = "0x60")]
		private UIRoomObserverItemView m_View;

		// Token: 0x04009F5F RID: 40799
		[Token(Token = "0x4009F5F")]
		[FieldOffset(Offset = "0x68")]
		private RoomPlayerInfo m_info;

		// Token: 0x04009F60 RID: 40800
		[Token(Token = "0x4009F60")]
		[FieldOffset(Offset = "0x70")]
		private bool m_IsEmptySeat;

		// Token: 0x04009F61 RID: 40801
		[Token(Token = "0x4009F61")]
		[FieldOffset(Offset = "0x78")]
		private UIModelCustomRoom m_Model;
	}
}
