using System;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020013C8 RID: 5064
	[Token(Token = "0x20013C8")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EBEC0", Offset = "0x10EBEC0")]
	public class UISuperFighterBoxPreviewItemController : UIEasyListItemController, IEasyList
	{
		// Token: 0x060052CF RID: 21199 RVA: 0x00018D38 File Offset: 0x00016F38
		[Token(Token = "0x60052CF")]
		[Address(RVA = "0x1F43DFC", Offset = "0x1F43DFC", VA = "0x7BBC743DFC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060052D0 RID: 21200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052D0")]
		[Address(RVA = "0x1F43E4C", Offset = "0x1F43E4C", VA = "0x7BBC743E4C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060052D1 RID: 21201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052D1")]
		[Address(RVA = "0x1F43F34", Offset = "0x1F43F34", VA = "0x7BBC743F34", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060052D2 RID: 21202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052D2")]
		[Address(RVA = "0x1F43F3C", Offset = "0x1F43F3C", VA = "0x7BBC743F3C", Slot = "35")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		// Token: 0x060052D3 RID: 21203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052D3")]
		[Address(RVA = "0x1F43F6C", Offset = "0x1F43F6C", VA = "0x7BBC743F6C", Slot = "34")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		// Token: 0x060052D4 RID: 21204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052D4")]
		[Address(RVA = "0x1F44028", Offset = "0x1F44028", VA = "0x7BBC744028", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x060052D5 RID: 21205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052D5")]
		[Address(RVA = "0x1F443EC", Offset = "0x1F443EC", VA = "0x7BBC7443EC")]
		public UISuperFighterBoxPreviewItemController()
		{
		}

		// Token: 0x04007897 RID: 30871
		[Token(Token = "0x4007897")]
		[FieldOffset(Offset = "0x70")]
		private UISuperFighterBoxPreviewItemView m_View;

		// Token: 0x04007898 RID: 30872
		[Token(Token = "0x4007898")]
		[FieldOffset(Offset = "0x78")]
		private UIModelSuperFighter m_ModelSuperFighter;

		// Token: 0x04007899 RID: 30873
		[Token(Token = "0x4007899")]
		[FieldOffset(Offset = "0x80")]
		private uint m_BoxId;

		// Token: 0x020013C9 RID: 5065
		[Token(Token = "0x20013C9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EBEF8", Offset = "0x10EBEF8")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060052D7 RID: 21207 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60052D7")]
			[Address(RVA = "0x1F44458", Offset = "0x1F44458", VA = "0x7BBC744458")]
			public <>c()
			{
			}

			// Token: 0x060052D8 RID: 21208 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60052D8")]
			[Address(RVA = "0x1F44460", Offset = "0x1F44460", VA = "0x7BBC744460")]
			internal BaseItemInfo <SetViewData>b__8_0(TreasureBoxShowData item)
			{
				return null;
			}

			// Token: 0x0400789A RID: 30874
			[Token(Token = "0x400789A")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UISuperFighterBoxPreviewItemController.<>c <>9;

			// Token: 0x0400789B RID: 30875
			[Token(Token = "0x400789B")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<TreasureBoxShowData, BaseItemInfo> <>9__8_0;
		}
	}
}
