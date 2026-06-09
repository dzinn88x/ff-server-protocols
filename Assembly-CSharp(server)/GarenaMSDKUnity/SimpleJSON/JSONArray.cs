using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Il2CppDummyDll;

namespace GarenaMSDKUnity.SimpleJSON
{
	// Token: 0x02002BB3 RID: 11187
	[Token(Token = "0x2002BB3")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x10FF6EC", Offset = "0x10FF6EC")]
	public class JSONArray : JSONNode
	{
		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x0600F783 RID: 63363 RVA: 0x00047220 File Offset: 0x00045420
		// (set) Token: 0x0600F784 RID: 63364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170011E0")]
		public override bool Inline
		{
			[Token(Token = "0x600F783")]
			[Address(RVA = "0x2742C20", Offset = "0x2742C20", VA = "0x7BBCF42C20", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600F784")]
			[Address(RVA = "0x2742C28", Offset = "0x2742C28", VA = "0x7BBCF42C28", Slot = "19")]
			set
			{
			}
		}

		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x0600F785 RID: 63365 RVA: 0x00047238 File Offset: 0x00045438
		[Token(Token = "0x170011E1")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x600F785")]
			[Address(RVA = "0x2742C34", Offset = "0x2742C34", VA = "0x7BBCF42C34", Slot = "4")]
			get
			{
				return (JSONNodeType)0;
			}
		}

		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x0600F786 RID: 63366 RVA: 0x00047250 File Offset: 0x00045450
		[Token(Token = "0x170011E2")]
		public override bool IsArray
		{
			[Token(Token = "0x600F786")]
			[Address(RVA = "0x2742C3C", Offset = "0x2742C3C", VA = "0x7BBCF42C3C", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F787 RID: 63367 RVA: 0x00047268 File Offset: 0x00045468
		[Token(Token = "0x600F787")]
		[Address(RVA = "0x2742C44", Offset = "0x2742C44", VA = "0x7BBCF42C44", Slot = "28")]
		public override JSONNode.Enumerator GetEnumerator()
		{
			return default(JSONNode.Enumerator);
		}

		// Token: 0x170011E3 RID: 4579
		// (get) Token: 0x0600F788 RID: 63368 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F789 RID: 63369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170011E3")]
		public override JSONNode Item
		{
			[Token(Token = "0x600F788")]
			[Address(RVA = "0x2742D18", Offset = "0x2742D18", VA = "0x7BBCF42D18", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600F789")]
			[Address(RVA = "0x2742E60", Offset = "0x2742E60", VA = "0x7BBCF42E60", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x0600F78A RID: 63370 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F78B RID: 63371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170011E4")]
		public override JSONNode Item
		{
			[Token(Token = "0x600F78A")]
			[Address(RVA = "0x27431C4", Offset = "0x27431C4", VA = "0x7BBCF431C4", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600F78B")]
			[Address(RVA = "0x2743224", Offset = "0x2743224", VA = "0x7BBCF43224", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x0600F78C RID: 63372 RVA: 0x00047280 File Offset: 0x00045480
		[Token(Token = "0x170011E5")]
		public override int Count
		{
			[Token(Token = "0x600F78C")]
			[Address(RVA = "0x27432EC", Offset = "0x27432EC", VA = "0x7BBCF432EC", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600F78D RID: 63373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F78D")]
		[Address(RVA = "0x274334C", Offset = "0x274334C", VA = "0x7BBCF4334C", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		// Token: 0x0600F78E RID: 63374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F78E")]
		[Address(RVA = "0x2743414", Offset = "0x2743414", VA = "0x7BBCF43414", Slot = "23")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		// Token: 0x0600F78F RID: 63375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F78F")]
		[Address(RVA = "0x27434F0", Offset = "0x27434F0", VA = "0x7BBCF434F0", Slot = "24")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x0600F790 RID: 63376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011E6")]
		public override IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x600F790")]
			[Address(RVA = "0x2743568", Offset = "0x2743568", VA = "0x7BBCF43568", Slot = "25")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x114B980", Offset = "0x114B980")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F791 RID: 63377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F791")]
		[Address(RVA = "0x2743624", Offset = "0x2743624", VA = "0x7BBCF43624", Slot = "27")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		// Token: 0x0600F792 RID: 63378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F792")]
		[Address(RVA = "0x2743820", Offset = "0x2743820", VA = "0x7BBCF43820")]
		public JSONArray()
		{
		}

		// Token: 0x04011B54 RID: 72532
		[Token(Token = "0x4011B54")]
		[FieldOffset(Offset = "0x10")]
		private List<JSONNode> m_List;

		// Token: 0x04011B55 RID: 72533
		[Token(Token = "0x4011B55")]
		[FieldOffset(Offset = "0x18")]
		private bool inline;

		// Token: 0x02002BB4 RID: 11188
		[Token(Token = "0x2002BB4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FF724", Offset = "0x10FF724")]
		private sealed class <get_Children>d__22 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			// Token: 0x0600F793 RID: 63379 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F793")]
			[Address(RVA = "0x27435EC", Offset = "0x27435EC", VA = "0x7BBCF435EC")]
			[DebuggerHidden]
			public <get_Children>d__22(int <>1__state)
			{
			}

			// Token: 0x0600F794 RID: 63380 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F794")]
			[Address(RVA = "0x27438B8", Offset = "0x27438B8", VA = "0x7BBCF438B8", Slot = "7")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600F795 RID: 63381 RVA: 0x00047298 File Offset: 0x00045498
			[Token(Token = "0x600F795")]
			[Address(RVA = "0x274392C", Offset = "0x274392C", VA = "0x7BBCF4392C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x0600F796 RID: 63382 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F796")]
			[Address(RVA = "0x27438D4", Offset = "0x27438D4", VA = "0x7BBCF438D4")]
			private void <>m__Finally1()
			{
			}

			// Token: 0x170011E7 RID: 4583
			// (get) Token: 0x0600F797 RID: 63383 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011E7")]
			private JSONNode Current
			{
				[Token(Token = "0x600F797")]
				[Address(RVA = "0x2743AA0", Offset = "0x2743AA0", VA = "0x7BBCF43AA0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600F798 RID: 63384 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F798")]
			[Address(RVA = "0x2743AA8", Offset = "0x2743AA8", VA = "0x7BBCF43AA8", Slot = "10")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170011E8 RID: 4584
			// (get) Token: 0x0600F799 RID: 63385 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011E8")]
			private object Current
			{
				[Token(Token = "0x600F799")]
				[Address(RVA = "0x2743B10", Offset = "0x2743B10", VA = "0x7BBCF43B10", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600F79A RID: 63386 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600F79A")]
			[Address(RVA = "0x2743B18", Offset = "0x2743B18", VA = "0x7BBCF43B18", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> GetEnumerator()
			{
				return null;
			}

			// Token: 0x0600F79B RID: 63387 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600F79B")]
			[Address(RVA = "0x2743BC8", Offset = "0x2743BC8", VA = "0x7BBCF43BC8", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x04011B56 RID: 72534
			[Token(Token = "0x4011B56")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04011B57 RID: 72535
			[Token(Token = "0x4011B57")]
			[FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			// Token: 0x04011B58 RID: 72536
			[Token(Token = "0x4011B58")]
			[FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			// Token: 0x04011B59 RID: 72537
			[Token(Token = "0x4011B59")]
			[FieldOffset(Offset = "0x28")]
			public JSONArray <>4__this;

			// Token: 0x04011B5A RID: 72538
			[Token(Token = "0x4011B5A")]
			[FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator <>7__wrap1;
		}
	}
}
