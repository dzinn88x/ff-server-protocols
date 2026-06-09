using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200170A RID: 5898
	[Token(Token = "0x200170A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F151C", Offset = "0x10F151C")]
	public class UIChatWorldContainerController : UIChatBaseContainerController, IUIModelDataChangeObserver
	{
		// Token: 0x06006DC9 RID: 28105 RVA: 0x0001EF00 File Offset: 0x0001D100
		[Token(Token = "0x6006DC9")]
		[Address(RVA = "0x1BF0D00", Offset = "0x1BF0D00", VA = "0x7BBC3F0D00")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006DCA RID: 28106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DCA")]
		[Address(RVA = "0x1BF0D50", Offset = "0x1BF0D50", VA = "0x7BBC3F0D50", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006DCB RID: 28107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DCB")]
		[Address(RVA = "0x1BF0EC8", Offset = "0x1BF0EC8", VA = "0x7BBC3F0EC8")]
		private void OnAddLiftTopMessage(object[] data)
		{
		}

		// Token: 0x06006DCC RID: 28108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DCC")]
		[Address(RVA = "0x1BF1080", Offset = "0x1BF1080", VA = "0x7BBC3F1080", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06006DCD RID: 28109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DCD")]
		[Address(RVA = "0x1BF11D4", Offset = "0x1BF11D4", VA = "0x7BBC3F11D4", Slot = "28")]
		public override GameObject GetContentNode()
		{
			return null;
		}

		// Token: 0x06006DCE RID: 28110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DCE")]
		[Address(RVA = "0x1BF1200", Offset = "0x1BF1200", VA = "0x7BBC3F1200", Slot = "29")]
		public override GameObject GetEmptyNode()
		{
			return null;
		}

		// Token: 0x06006DCF RID: 28111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DCF")]
		[Address(RVA = "0x1BF122C", Offset = "0x1BF122C", VA = "0x7BBC3F122C", Slot = "30")]
		public override UIScrollView GetMessageList()
		{
			return null;
		}

		// Token: 0x06006DD0 RID: 28112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DD0")]
		[Address(RVA = "0x1BF1258", Offset = "0x1BF1258", VA = "0x7BBC3F1258", Slot = "31")]
		public override void InitWidget(Transform parent)
		{
		}

		// Token: 0x06006DD1 RID: 28113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DD1")]
		[Address(RVA = "0x1BF147C", Offset = "0x1BF147C", VA = "0x7BBC3F147C", Slot = "32")]
		public override void RefreshContentNode()
		{
		}

		// Token: 0x06006DD2 RID: 28114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DD2")]
		[Address(RVA = "0x1BF1480", Offset = "0x1BF1480", VA = "0x7BBC3F1480", Slot = "33")]
		private void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006DD3 RID: 28115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DD3")]
		[Address(RVA = "0x1BF0F8C", Offset = "0x1BF0F8C", VA = "0x7BBC3F0F8C")]
		private void AddLiftTopMessage(MessageInfo info)
		{
		}

		// Token: 0x06006DD4 RID: 28116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DD4")]
		[Address(RVA = "0x1BF15DC", Offset = "0x1BF15DC", VA = "0x7BBC3F15DC")]
		private void ShowLiftTopMessage()
		{
		}

		// Token: 0x06006DD5 RID: 28117 RVA: 0x0001EF18 File Offset: 0x0001D118
		[Token(Token = "0x6006DD5")]
		[Address(RVA = "0x1BF1800", Offset = "0x1BF1800", VA = "0x7BBC3F1800", Slot = "34")]
		private uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006DD6 RID: 28118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DD6")]
		[Address(RVA = "0x1BF1840", Offset = "0x1BF1840", VA = "0x7BBC3F1840")]
		public UIChatWorldContainerController()
		{
		}

		// Token: 0x06006DD7 RID: 28119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DD7")]
		[Address(RVA = "0x1BF18B0", Offset = "0x1BF18B0", VA = "0x7BBC3F18B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114134C", Offset = "0x114134C")]
		private void <ShowLiftTopMessage>b__16_0()
		{
		}

		// Token: 0x040088B5 RID: 34997
		[Token(Token = "0x40088B5")]
		[FieldOffset(Offset = "0x58")]
		private UIChatWorldContainerView m_View;

		// Token: 0x040088B6 RID: 34998
		[Token(Token = "0x40088B6")]
		[FieldOffset(Offset = "0x60")]
		private UIModelChat m_Model;

		// Token: 0x040088B7 RID: 34999
		[Token(Token = "0x40088B7")]
		[FieldOffset(Offset = "0x68")]
		private uint m_UpdateLiftTopCallID;

		// Token: 0x040088B8 RID: 35000
		[Token(Token = "0x40088B8")]
		[FieldOffset(Offset = "0x6C")]
		private uint m_HideLiftTopCallID;

		// Token: 0x040088B9 RID: 35001
		[Token(Token = "0x40088B9")]
		[FieldOffset(Offset = "0x70")]
		private Queue<MessageInfo> m_LiftTopMessageList;
	}
}
