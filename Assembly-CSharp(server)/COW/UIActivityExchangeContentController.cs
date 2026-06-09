using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020013EA RID: 5098
	[Token(Token = "0x20013EA")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC220", Offset = "0x10EC220")]
	public class UIActivityExchangeContentController : UIActivityContentController, IUIModelDataChangeObserver
	{
		// Token: 0x060053C9 RID: 21449 RVA: 0x00019020 File Offset: 0x00017220
		[Token(Token = "0x60053C9")]
		[Address(RVA = "0x1A4B6F0", Offset = "0x1A4B6F0", VA = "0x7BBC24B6F0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060053CA RID: 21450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053CA")]
		[Address(RVA = "0x1A4B740", Offset = "0x1A4B740", VA = "0x7BBC24B740", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060053CB RID: 21451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053CB")]
		[Address(RVA = "0x1A4B844", Offset = "0x1A4B844", VA = "0x7BBC24B844", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060053CC RID: 21452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053CC")]
		[Address(RVA = "0x1A4B884", Offset = "0x1A4B884", VA = "0x7BBC24B884", Slot = "28")]
		public override void SetData(object data)
		{
		}

		// Token: 0x060053CD RID: 21453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053CD")]
		[Address(RVA = "0x1A4BE1C", Offset = "0x1A4BE1C", VA = "0x7BBC24BE1C")]
		private void CreateEventDescList()
		{
		}

		// Token: 0x060053CE RID: 21454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053CE")]
		[Address(RVA = "0x1A4C558", Offset = "0x1A4C558", VA = "0x7BBC24C558")]
		private UIActivityExchangeItemController CreateEventDesc(ClientActivityDesc desc)
		{
			return null;
		}

		// Token: 0x060053CF RID: 21455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053CF")]
		[Address(RVA = "0x1A4C678", Offset = "0x1A4C678", VA = "0x7BBC24C678", Slot = "29")]
		public override void Reload()
		{
		}

		// Token: 0x060053D0 RID: 21456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053D0")]
		[Address(RVA = "0x1A4C7A0", Offset = "0x1A4C7A0", VA = "0x7BBC24C7A0", Slot = "30")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060053D1 RID: 21457 RVA: 0x00019038 File Offset: 0x00017238
		[Token(Token = "0x60053D1")]
		[Address(RVA = "0x1A4C824", Offset = "0x1A4C824", VA = "0x7BBC24C824", Slot = "31")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060053D2 RID: 21458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053D2")]
		[Address(RVA = "0x1A4C868", Offset = "0x1A4C868", VA = "0x7BBC24C868")]
		public void SetDragViewSize(int width)
		{
		}

		// Token: 0x060053D3 RID: 21459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053D3")]
		[Address(RVA = "0x1A4CB38", Offset = "0x1A4CB38", VA = "0x7BBC24CB38")]
		public UIActivityExchangeContentController()
		{
		}

		// Token: 0x04007956 RID: 31062
		[Token(Token = "0x4007956")]
		[FieldOffset(Offset = "0x58")]
		private UIActivityExchangeContentView m_View;

		// Token: 0x04007957 RID: 31063
		[Token(Token = "0x4007957")]
		[FieldOffset(Offset = "0x60")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x04007958 RID: 31064
		[Token(Token = "0x4007958")]
		[FieldOffset(Offset = "0x68")]
		private UIModelInventory m_ModelInventory;

		// Token: 0x04007959 RID: 31065
		[Token(Token = "0x4007959")]
		[FieldOffset(Offset = "0x70")]
		private List<ClientActivityDesc> m_Descs;

		// Token: 0x0400795A RID: 31066
		[Token(Token = "0x400795A")]
		[FieldOffset(Offset = "0x78")]
		private List<UIActivityExchangeItemController> m_ExchangeDescUIs;

		// Token: 0x0400795B RID: 31067
		[Token(Token = "0x400795B")]
		[FieldOffset(Offset = "0x80")]
		private int m_RightAreaWidth;

		// Token: 0x020013EB RID: 5099
		[Token(Token = "0x20013EB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EC258", Offset = "0x10EC258")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060053D5 RID: 21461 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60053D5")]
			[Address(RVA = "0x194E7CC", Offset = "0x194E7CC", VA = "0x7BBC14E7CC")]
			public <>c()
			{
			}

			// Token: 0x060053D6 RID: 21462 RVA: 0x00019050 File Offset: 0x00017250
			[Token(Token = "0x60053D6")]
			[Address(RVA = "0x194E7D4", Offset = "0x194E7D4", VA = "0x7BBC14E7D4")]
			internal int <CreateEventDescList>b__10_0(ClientActivityDesc x, ClientActivityDesc y)
			{
				return 0;
			}

			// Token: 0x060053D7 RID: 21463 RVA: 0x00019068 File Offset: 0x00017268
			[Token(Token = "0x60053D7")]
			[Address(RVA = "0x194E818", Offset = "0x194E818", VA = "0x7BBC14E818")]
			internal int <CreateEventDescList>b__10_1(ClientActivityDesc x, ClientActivityDesc y)
			{
				return 0;
			}

			// Token: 0x060053D8 RID: 21464 RVA: 0x00019080 File Offset: 0x00017280
			[Token(Token = "0x60053D8")]
			[Address(RVA = "0x194E85C", Offset = "0x194E85C", VA = "0x7BBC14E85C")]
			internal int <CreateEventDescList>b__10_2(ClientActivityDesc x, ClientActivityDesc y)
			{
				return 0;
			}

			// Token: 0x0400795C RID: 31068
			[Token(Token = "0x400795C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIActivityExchangeContentController.<>c <>9;

			// Token: 0x0400795D RID: 31069
			[Token(Token = "0x400795D")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<ClientActivityDesc> <>9__10_0;

			// Token: 0x0400795E RID: 31070
			[Token(Token = "0x400795E")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<ClientActivityDesc> <>9__10_1;

			// Token: 0x0400795F RID: 31071
			[Token(Token = "0x400795F")]
			[FieldOffset(Offset = "0x18")]
			public static Comparison<ClientActivityDesc> <>9__10_2;
		}
	}
}
