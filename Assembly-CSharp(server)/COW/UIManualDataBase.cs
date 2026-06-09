using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001D24 RID: 7460
	[Token(Token = "0x2001D24")]
	public class UIManualDataBase
	{
		// Token: 0x0600A28D RID: 41613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A28D")]
		[Address(RVA = "0x1DF7F68", Offset = "0x1DF7F68", VA = "0x7BBC5F7F68", Slot = "4")]
		public virtual void Init()
		{
		}

		// Token: 0x0600A28E RID: 41614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A28E")]
		[Address(RVA = "0x1DF7F70", Offset = "0x1DF7F70", VA = "0x7BBC5F7F70")]
		public UIManualDataBase()
		{
		}

		// Token: 0x0400A8BC RID: 43196
		[Token(Token = "0x400A8BC")]
		[FieldOffset(Offset = "0x10")]
		public UIManualDataBase.Type m_ContentType;

		// Token: 0x0400A8BD RID: 43197
		[Token(Token = "0x400A8BD")]
		[FieldOffset(Offset = "0x18")]
		public List<ManualChallenge> m_Desc;

		// Token: 0x0400A8BE RID: 43198
		[Token(Token = "0x400A8BE")]
		[FieldOffset(Offset = "0x20")]
		public UIManualDataBase.ContentCreator m_Creator;

		// Token: 0x0400A8BF RID: 43199
		[Token(Token = "0x400A8BF")]
		[FieldOffset(Offset = "0x28")]
		public string m_TitleKey;

		// Token: 0x0400A8C0 RID: 43200
		[Token(Token = "0x400A8C0")]
		[FieldOffset(Offset = "0x30")]
		public ETipsType m_TipsType;

		// Token: 0x0400A8C1 RID: 43201
		[Token(Token = "0x400A8C1")]
		[FieldOffset(Offset = "0x34")]
		public ETipsType m_NewTipsType;

		// Token: 0x0400A8C2 RID: 43202
		[Token(Token = "0x400A8C2")]
		[FieldOffset(Offset = "0x38")]
		public bool m_ToFirstPage;

		// Token: 0x0400A8C3 RID: 43203
		[Token(Token = "0x400A8C3")]
		[FieldOffset(Offset = "0x39")]
		public bool m_ToLastPage;

		// Token: 0x0400A8C4 RID: 43204
		[Token(Token = "0x400A8C4")]
		[FieldOffset(Offset = "0x3A")]
		public bool m_IsFirstSubTabInTotalList;

		// Token: 0x0400A8C5 RID: 43205
		[Token(Token = "0x400A8C5")]
		[FieldOffset(Offset = "0x3B")]
		public bool m_IsLastSubTabInTotalList;

		// Token: 0x0400A8C6 RID: 43206
		[Token(Token = "0x400A8C6")]
		[FieldOffset(Offset = "0x40")]
		public Action m_OnPrevPageEnd;

		// Token: 0x0400A8C7 RID: 43207
		[Token(Token = "0x400A8C7")]
		[FieldOffset(Offset = "0x48")]
		public Action m_OnNextPageEnd;

		// Token: 0x0400A8C8 RID: 43208
		[Token(Token = "0x400A8C8")]
		[FieldOffset(Offset = "0x50")]
		public Action<bool> m_OnPageUpdate;

		// Token: 0x0400A8C9 RID: 43209
		[Token(Token = "0x400A8C9")]
		[FieldOffset(Offset = "0x58")]
		public int m_Index;

		// Token: 0x0400A8CA RID: 43210
		[Token(Token = "0x400A8CA")]
		[FieldOffset(Offset = "0x5C")]
		public int m_Type;

		// Token: 0x02001D25 RID: 7461
		[Token(Token = "0x2001D25")]
		public enum Type
		{
			// Token: 0x0400A8CC RID: 43212
			[Token(Token = "0x400A8CC")]
			NONE,
			// Token: 0x0400A8CD RID: 43213
			[Token(Token = "0x400A8CD")]
			GROW,
			// Token: 0x0400A8CE RID: 43214
			[Token(Token = "0x400A8CE")]
			MAP_DEBRIS,
			// Token: 0x0400A8CF RID: 43215
			[Token(Token = "0x400A8CF")]
			MAP_SUPPLY,
			// Token: 0x0400A8D0 RID: 43216
			[Token(Token = "0x400A8D0")]
			MAP_EVENT,
			// Token: 0x0400A8D1 RID: 43217
			[Token(Token = "0x400A8D1")]
			MAP_MOV,
			// Token: 0x0400A8D2 RID: 43218
			[Token(Token = "0x400A8D2")]
			WEAPON,
			// Token: 0x0400A8D3 RID: 43219
			[Token(Token = "0x400A8D3")]
			MORE
		}

		// Token: 0x02001D26 RID: 7462
		// (Invoke) Token: 0x0600A290 RID: 41616
		[Token(Token = "0x2001D26")]
		public delegate UIManualContentBaseController ContentCreator();
	}
}
