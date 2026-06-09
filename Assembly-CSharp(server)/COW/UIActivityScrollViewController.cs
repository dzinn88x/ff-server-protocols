using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001403 RID: 5123
	[Token(Token = "0x2001403")]
	public class UIActivityScrollViewController : UIActivityContentController
	{
		// Token: 0x06005457 RID: 21591 RVA: 0x000192C0 File Offset: 0x000174C0
		[Token(Token = "0x6005457")]
		[Address(RVA = "0x195AB64", Offset = "0x195AB64", VA = "0x7BBC15AB64")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005458 RID: 21592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005458")]
		[Address(RVA = "0x195ABB4", Offset = "0x195ABB4", VA = "0x7BBC15ABB4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005459 RID: 21593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005459")]
		[Address(RVA = "0x195AC18", Offset = "0x195AC18", VA = "0x7BBC15AC18", Slot = "28")]
		public override void SetData(object data)
		{
		}

		// Token: 0x0600545A RID: 21594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600545A")]
		[Address(RVA = "0x195B070", Offset = "0x195B070", VA = "0x7BBC15B070")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113E728", Offset = "0x113E728")]
		private IEnumerator SetPos()
		{
			return null;
		}

		// Token: 0x0600545B RID: 21595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600545B")]
		[Address(RVA = "0x195B110", Offset = "0x195B110", VA = "0x7BBC15B110")]
		public UIActivityScrollViewController()
		{
		}

		// Token: 0x040079C6 RID: 31174
		[Token(Token = "0x40079C6")]
		[FieldOffset(Offset = "0x58")]
		private UIActivityScrollViewView m_View;

		// Token: 0x02001404 RID: 5124
		[Token(Token = "0x2001404")]
		public class Data
		{
			// Token: 0x0600545C RID: 21596 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600545C")]
			[Address(RVA = "0x195B2E0", Offset = "0x195B2E0", VA = "0x7BBC15B2E0")]
			public Data(uint goPos, string subGoPos, string image_url)
			{
			}

			// Token: 0x040079C7 RID: 31175
			[Token(Token = "0x40079C7")]
			[FieldOffset(Offset = "0x10")]
			public uint goPos;

			// Token: 0x040079C8 RID: 31176
			[Token(Token = "0x40079C8")]
			[FieldOffset(Offset = "0x18")]
			public string subGoPos;

			// Token: 0x040079C9 RID: 31177
			[Token(Token = "0x40079C9")]
			[FieldOffset(Offset = "0x20")]
			public string image_url;
		}

		// Token: 0x02001405 RID: 5125
		[Token(Token = "0x2001405")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EC498", Offset = "0x10EC498")]
		private sealed class <SetPos>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600545D RID: 21597 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600545D")]
			[Address(RVA = "0x195B0E4", Offset = "0x195B0E4", VA = "0x7BBC15B0E4")]
			[DebuggerHidden]
			public <SetPos>d__5(int <>1__state)
			{
			}

			// Token: 0x0600545E RID: 21598 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600545E")]
			[Address(RVA = "0x195B118", Offset = "0x195B118", VA = "0x7BBC15B118", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600545F RID: 21599 RVA: 0x000192D8 File Offset: 0x000174D8
			[Token(Token = "0x600545F")]
			[Address(RVA = "0x195B11C", Offset = "0x195B11C", VA = "0x7BBC15B11C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000878 RID: 2168
			// (get) Token: 0x06005460 RID: 21600 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000878")]
			private object Current
			{
				[Token(Token = "0x6005460")]
				[Address(RVA = "0x195B268", Offset = "0x195B268", VA = "0x7BBC15B268", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005461 RID: 21601 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005461")]
			[Address(RVA = "0x195B270", Offset = "0x195B270", VA = "0x7BBC15B270", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000879 RID: 2169
			// (get) Token: 0x06005462 RID: 21602 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000879")]
			private object Current
			{
				[Token(Token = "0x6005462")]
				[Address(RVA = "0x195B2D8", Offset = "0x195B2D8", VA = "0x7BBC15B2D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040079CA RID: 31178
			[Token(Token = "0x40079CA")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040079CB RID: 31179
			[Token(Token = "0x40079CB")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040079CC RID: 31180
			[Token(Token = "0x40079CC")]
			[FieldOffset(Offset = "0x20")]
			public UIActivityScrollViewController <>4__this;
		}
	}
}
