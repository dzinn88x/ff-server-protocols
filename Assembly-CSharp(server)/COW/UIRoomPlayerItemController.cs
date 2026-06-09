using System;
using GCommon;
using Il2CppDummyDll;
using tcp;
using UnityEngine;

namespace COW
{
	// Token: 0x02001B6E RID: 7022
	[Token(Token = "0x2001B6E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FA05C", Offset = "0x10FA05C")]
	public class UIRoomPlayerItemController : UIBaseController
	{
		// Token: 0x0600972A RID: 38698 RVA: 0x00027E40 File Offset: 0x00026040
		[Token(Token = "0x600972A")]
		[Address(RVA = "0x1A1ED80", Offset = "0x1A1ED80", VA = "0x7BBC21ED80")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600972B RID: 38699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600972B")]
		[Address(RVA = "0x1A1EDD0", Offset = "0x1A1EDD0", VA = "0x7BBC21EDD0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600972C RID: 38700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600972C")]
		[Address(RVA = "0x1A1EF8C", Offset = "0x1A1EF8C", VA = "0x7BBC21EF8C", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x0600972D RID: 38701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600972D")]
		[Address(RVA = "0x1A1EF94", Offset = "0x1A1EF94", VA = "0x7BBC21EF94")]
		private void OnItemClick()
		{
		}

		// Token: 0x0600972E RID: 38702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600972E")]
		[Address(RVA = "0x1A1F64C", Offset = "0x1A1F64C", VA = "0x7BBC21F64C")]
		private void OnGotoSeat(object data)
		{
		}

		// Token: 0x0600972F RID: 38703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600972F")]
		[Address(RVA = "0x1A11584", Offset = "0x1A11584", VA = "0x7BBC211584")]
		public void SetUIData(RoomPlayerInfo info, int teamIndex, int memberIndex)
		{
		}

		// Token: 0x06009730 RID: 38704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009730")]
		[Address(RVA = "0x1A1F730", Offset = "0x1A1F730", VA = "0x7BBC21F730")]
		private void SetSimulationInfo()
		{
		}

		// Token: 0x06009731 RID: 38705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009731")]
		[Address(RVA = "0x1A1F930", Offset = "0x1A1F930", VA = "0x7BBC21F930")]
		private void ShowSimulationInfo()
		{
		}

		// Token: 0x06009732 RID: 38706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009732")]
		[Address(RVA = "0x1A1F8A0", Offset = "0x1A1F8A0", VA = "0x7BBC21F8A0")]
		private void HideSimulationInfo()
		{
		}

		// Token: 0x06009733 RID: 38707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009733")]
		[Address(RVA = "0x1A1FA7C", Offset = "0x1A1FA7C", VA = "0x7BBC21FA7C")]
		private void HideMaxInfo()
		{
		}

		// Token: 0x06009734 RID: 38708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009734")]
		[Address(RVA = "0x1A1FAF4", Offset = "0x1A1FAF4", VA = "0x7BBC21FAF4")]
		private void ShowMaxInfo()
		{
		}

		// Token: 0x06009735 RID: 38709 RVA: 0x00027E58 File Offset: 0x00026058
		[Token(Token = "0x6009735")]
		[Address(RVA = "0x1A1FCCC", Offset = "0x1A1FCCC", VA = "0x7BBC21FCCC")]
		private bool SwitchValidCheck(int from, int to)
		{
			return default(bool);
		}

		// Token: 0x06009736 RID: 38710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009736")]
		[Address(RVA = "0x1A1FE08", Offset = "0x1A1FE08", VA = "0x7BBC21FE08")]
		public UIRoomPlayerItemController()
		{
		}

		// Token: 0x06009738 RID: 38712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009738")]
		[Address(RVA = "0x1A1FE94", Offset = "0x1A1FE94", VA = "0x7BBC21FE94")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1144DA0", Offset = "0x1144DA0")]
		private void <OnItemClick>b__15_0()
		{
		}

		// Token: 0x04009F68 RID: 40808
		[Token(Token = "0x4009F68")]
		[FieldOffset(Offset = "0x0")]
		private static Color NAME_NORMAL;

		// Token: 0x04009F69 RID: 40809
		[Token(Token = "0x4009F69")]
		[FieldOffset(Offset = "0x10")]
		private static Color NAME_WARNING;

		// Token: 0x04009F6A RID: 40810
		[Token(Token = "0x4009F6A")]
		[FieldOffset(Offset = "0x58")]
		private UIRoomPlayerItemView m_View;

		// Token: 0x04009F6B RID: 40811
		[Token(Token = "0x4009F6B")]
		[FieldOffset(Offset = "0x60")]
		private RoomPlayerInfo m_info;

		// Token: 0x04009F6C RID: 40812
		[Token(Token = "0x4009F6C")]
		[FieldOffset(Offset = "0x68")]
		private bool m_IsEmptySeat;

		// Token: 0x04009F6D RID: 40813
		[Token(Token = "0x4009F6D")]
		[FieldOffset(Offset = "0x6C")]
		private uint m_TeamIndex;

		// Token: 0x04009F6E RID: 40814
		[Token(Token = "0x4009F6E")]
		[FieldOffset(Offset = "0x70")]
		private uint m_MemberIndex;

		// Token: 0x04009F6F RID: 40815
		[Token(Token = "0x4009F6F")]
		[FieldOffset(Offset = "0x74")]
		private Vector3 m_MaxIconDefaultPos;

		// Token: 0x04009F70 RID: 40816
		[Token(Token = "0x4009F70")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 m_MaxIconMovedPos;

		// Token: 0x04009F71 RID: 40817
		[Token(Token = "0x4009F71")]
		private const uint MAX_VERSION = 2U;

		// Token: 0x04009F72 RID: 40818
		[Token(Token = "0x4009F72")]
		[FieldOffset(Offset = "0x90")]
		private UIModelCustomRoom m_Model;

		// Token: 0x04009F73 RID: 40819
		[Token(Token = "0x4009F73")]
		[FieldOffset(Offset = "0x98")]
		private AutoChangeComp m_AutoChangeComp;
	}
}
