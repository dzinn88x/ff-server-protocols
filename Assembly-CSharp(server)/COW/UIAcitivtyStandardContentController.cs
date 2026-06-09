using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001408 RID: 5128
	[Token(Token = "0x2001408")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC4A8", Offset = "0x10EC4A8")]
	public class UIAcitivtyStandardContentController : UIActivityContentController
	{
		// Token: 0x06005476 RID: 21622 RVA: 0x00019338 File Offset: 0x00017538
		[Token(Token = "0x6005476")]
		[Address(RVA = "0x1A3CEB4", Offset = "0x1A3CEB4", VA = "0x7BBC23CEB4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005477 RID: 21623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005477")]
		[Address(RVA = "0x1A3CF04", Offset = "0x1A3CF04", VA = "0x7BBC23CF04", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005478 RID: 21624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005478")]
		[Address(RVA = "0x1A3CFBC", Offset = "0x1A3CFBC", VA = "0x7BBC23CFBC", Slot = "28")]
		public override void SetData(object data)
		{
		}

		// Token: 0x06005479 RID: 21625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005479")]
		[Address(RVA = "0x1A3D3A0", Offset = "0x1A3D3A0", VA = "0x7BBC23D3A0")]
		private void CreateEventDescList()
		{
		}

		// Token: 0x0600547A RID: 21626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600547A")]
		[Address(RVA = "0x1A3DB7C", Offset = "0x1A3DB7C", VA = "0x7BBC23DB7C")]
		private ActivityAwardDescription CreateEventDesc(ClientActivityDesc desc)
		{
			return null;
		}

		// Token: 0x0600547B RID: 21627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600547B")]
		[Address(RVA = "0x1A3DCB8", Offset = "0x1A3DCB8", VA = "0x7BBC23DCB8", Slot = "29")]
		public override void Reload()
		{
		}

		// Token: 0x0600547C RID: 21628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600547C")]
		[Address(RVA = "0x1A3DDE0", Offset = "0x1A3DDE0", VA = "0x7BBC23DDE0")]
		public void SetWidgetWidth(int width)
		{
		}

		// Token: 0x0600547D RID: 21629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600547D")]
		[Address(RVA = "0x1A3E0E4", Offset = "0x1A3E0E4", VA = "0x7BBC23E0E4")]
		public UIAcitivtyStandardContentController()
		{
		}

		// Token: 0x040079D4 RID: 31188
		[Token(Token = "0x40079D4")]
		[FieldOffset(Offset = "0x58")]
		private UIActivityStandardContentView m_View;

		// Token: 0x040079D5 RID: 31189
		[Token(Token = "0x40079D5")]
		[FieldOffset(Offset = "0x60")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x040079D6 RID: 31190
		[Token(Token = "0x40079D6")]
		[FieldOffset(Offset = "0x68")]
		private List<ClientActivityDesc> m_Descs;

		// Token: 0x040079D7 RID: 31191
		[Token(Token = "0x40079D7")]
		[FieldOffset(Offset = "0x70")]
		private List<ActivityAwardDescription> m_AwardDescUIs;

		// Token: 0x02001409 RID: 5129
		[Token(Token = "0x2001409")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EC4E0", Offset = "0x10EC4E0")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600547F RID: 21631 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600547F")]
			[Address(RVA = "0x1A3E1E0", Offset = "0x1A3E1E0", VA = "0x7BBC23E1E0")]
			public <>c()
			{
			}

			// Token: 0x06005480 RID: 21632 RVA: 0x00019350 File Offset: 0x00017550
			[Token(Token = "0x6005480")]
			[Address(RVA = "0x1A3E1E8", Offset = "0x1A3E1E8", VA = "0x7BBC23E1E8")]
			internal int <CreateEventDescList>b__7_0(ClientActivityDesc x, ClientActivityDesc y)
			{
				return 0;
			}

			// Token: 0x06005481 RID: 21633 RVA: 0x00019368 File Offset: 0x00017568
			[Token(Token = "0x6005481")]
			[Address(RVA = "0x1A3E22C", Offset = "0x1A3E22C", VA = "0x7BBC23E22C")]
			internal int <CreateEventDescList>b__7_1(ClientActivityDesc x, ClientActivityDesc y)
			{
				return 0;
			}

			// Token: 0x06005482 RID: 21634 RVA: 0x00019380 File Offset: 0x00017580
			[Token(Token = "0x6005482")]
			[Address(RVA = "0x1A3E270", Offset = "0x1A3E270", VA = "0x7BBC23E270")]
			internal int <CreateEventDescList>b__7_2(ClientActivityDesc x, ClientActivityDesc y)
			{
				return 0;
			}

			// Token: 0x040079D8 RID: 31192
			[Token(Token = "0x40079D8")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIAcitivtyStandardContentController.<>c <>9;

			// Token: 0x040079D9 RID: 31193
			[Token(Token = "0x40079D9")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<ClientActivityDesc> <>9__7_0;

			// Token: 0x040079DA RID: 31194
			[Token(Token = "0x40079DA")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<ClientActivityDesc> <>9__7_1;

			// Token: 0x040079DB RID: 31195
			[Token(Token = "0x40079DB")]
			[FieldOffset(Offset = "0x18")]
			public static Comparison<ClientActivityDesc> <>9__7_2;
		}
	}
}
