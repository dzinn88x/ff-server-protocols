using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Il2CppDummyDll;

namespace GarenaMSDKUnity.SimpleJSON
{
	// Token: 0x02002BB5 RID: 11189
	[Token(Token = "0x2002BB5")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x10FF734", Offset = "0x10FF734")]
	public class JSONObject : JSONNode
	{
		// Token: 0x170011E9 RID: 4585
		// (get) Token: 0x0600F79C RID: 63388 RVA: 0x000472B0 File Offset: 0x000454B0
		// (set) Token: 0x0600F79D RID: 63389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170011E9")]
		public override bool Inline
		{
			[Token(Token = "0x600F79C")]
			[Address(RVA = "0x2747508", Offset = "0x2747508", VA = "0x7BBCF47508", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600F79D")]
			[Address(RVA = "0x2747510", Offset = "0x2747510", VA = "0x7BBCF47510", Slot = "19")]
			set
			{
			}
		}

		// Token: 0x170011EA RID: 4586
		// (get) Token: 0x0600F79E RID: 63390 RVA: 0x000472C8 File Offset: 0x000454C8
		[Token(Token = "0x170011EA")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x600F79E")]
			[Address(RVA = "0x274751C", Offset = "0x274751C", VA = "0x7BBCF4751C", Slot = "4")]
			get
			{
				return (JSONNodeType)0;
			}
		}

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x0600F79F RID: 63391 RVA: 0x000472E0 File Offset: 0x000454E0
		[Token(Token = "0x170011EB")]
		public override bool IsObject
		{
			[Token(Token = "0x600F79F")]
			[Address(RVA = "0x2747524", Offset = "0x2747524", VA = "0x7BBCF47524", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F7A0 RID: 63392 RVA: 0x000472F8 File Offset: 0x000454F8
		[Token(Token = "0x600F7A0")]
		[Address(RVA = "0x274752C", Offset = "0x274752C", VA = "0x7BBCF4752C", Slot = "28")]
		public override JSONNode.Enumerator GetEnumerator()
		{
			return default(JSONNode.Enumerator);
		}

		// Token: 0x170011EC RID: 4588
		// (get) Token: 0x0600F7A1 RID: 63393 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F7A2 RID: 63394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170011EC")]
		public override JSONNode Item
		{
			[Token(Token = "0x600F7A1")]
			[Address(RVA = "0x27475D0", Offset = "0x27475D0", VA = "0x7BBCF475D0", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600F7A2")]
			[Address(RVA = "0x27476A0", Offset = "0x27476A0", VA = "0x7BBCF476A0", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x170011ED RID: 4589
		// (get) Token: 0x0600F7A3 RID: 63395 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F7A4 RID: 63396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170011ED")]
		public override JSONNode Item
		{
			[Token(Token = "0x600F7A3")]
			[Address(RVA = "0x27477CC", Offset = "0x27477CC", VA = "0x7BBCF477CC", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600F7A4")]
			[Address(RVA = "0x2747890", Offset = "0x2747890", VA = "0x7BBCF47890", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x0600F7A5 RID: 63397 RVA: 0x00047310 File Offset: 0x00045510
		[Token(Token = "0x170011EE")]
		public override int Count
		{
			[Token(Token = "0x600F7A5")]
			[Address(RVA = "0x27479DC", Offset = "0x27479DC", VA = "0x7BBCF479DC", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600F7A6 RID: 63398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7A6")]
		[Address(RVA = "0x2747A3C", Offset = "0x2747A3C", VA = "0x7BBCF47A3C", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		// Token: 0x0600F7A7 RID: 63399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F7A7")]
		[Address(RVA = "0x2747BD8", Offset = "0x2747BD8", VA = "0x7BBCF47BD8", Slot = "22")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		// Token: 0x0600F7A8 RID: 63400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F7A8")]
		[Address(RVA = "0x2747CB0", Offset = "0x2747CB0", VA = "0x7BBCF47CB0", Slot = "23")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		// Token: 0x0600F7A9 RID: 63401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F7A9")]
		[Address(RVA = "0x2747DB0", Offset = "0x2747DB0", VA = "0x7BBCF47DB0", Slot = "24")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		// Token: 0x170011EF RID: 4591
		// (get) Token: 0x0600F7AA RID: 63402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011EF")]
		public override IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x600F7AA")]
			[Address(RVA = "0x2747F6C", Offset = "0x2747F6C", VA = "0x7BBCF47F6C", Slot = "25")]
			[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x114BA54", Offset = "0x114BA54")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F7AB RID: 63403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7AB")]
		[Address(RVA = "0x2748028", Offset = "0x2748028", VA = "0x7BBCF48028", Slot = "27")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		// Token: 0x0600F7AC RID: 63404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7AC")]
		[Address(RVA = "0x27441EC", Offset = "0x27441EC", VA = "0x7BBCF441EC")]
		public JSONObject()
		{
		}

		// Token: 0x04011B5B RID: 72539
		[Token(Token = "0x4011B5B")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, JSONNode> m_Dict;

		// Token: 0x04011B5C RID: 72540
		[Token(Token = "0x4011B5C")]
		[FieldOffset(Offset = "0x18")]
		private bool inline;

		// Token: 0x02002BB6 RID: 11190
		[Token(Token = "0x2002BB6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FF76C", Offset = "0x10FF76C")]
		private sealed class <>c__DisplayClass21_0
		{
			// Token: 0x0600F7AD RID: 63405 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F7AD")]
			[Address(RVA = "0x2747F64", Offset = "0x2747F64", VA = "0x7BBCF47F64")]
			public <>c__DisplayClass21_0()
			{
			}

			// Token: 0x0600F7AE RID: 63406 RVA: 0x00047328 File Offset: 0x00045528
			[Token(Token = "0x600F7AE")]
			[Address(RVA = "0x27483D0", Offset = "0x27483D0", VA = "0x7BBCF483D0")]
			internal bool <Remove>b__0(KeyValuePair<string, JSONNode> k)
			{
				return default(bool);
			}

			// Token: 0x04011B5D RID: 72541
			[Token(Token = "0x4011B5D")]
			[FieldOffset(Offset = "0x10")]
			public JSONNode aNode;
		}

		// Token: 0x02002BB7 RID: 11191
		[Token(Token = "0x2002BB7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FF77C", Offset = "0x10FF77C")]
		private sealed class <get_Children>d__23 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			// Token: 0x0600F7AF RID: 63407 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F7AF")]
			[Address(RVA = "0x2747FF0", Offset = "0x2747FF0", VA = "0x7BBCF47FF0")]
			[DebuggerHidden]
			public <get_Children>d__23(int <>1__state)
			{
			}

			// Token: 0x0600F7B0 RID: 63408 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F7B0")]
			[Address(RVA = "0x274846C", Offset = "0x274846C", VA = "0x7BBCF4846C", Slot = "7")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600F7B1 RID: 63409 RVA: 0x00047340 File Offset: 0x00045540
			[Token(Token = "0x600F7B1")]
			[Address(RVA = "0x27484E0", Offset = "0x27484E0", VA = "0x7BBCF484E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x0600F7B2 RID: 63410 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F7B2")]
			[Address(RVA = "0x2748488", Offset = "0x2748488", VA = "0x7BBCF48488")]
			private void <>m__Finally1()
			{
			}

			// Token: 0x170011F0 RID: 4592
			// (get) Token: 0x0600F7B3 RID: 63411 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011F0")]
			private JSONNode Current
			{
				[Token(Token = "0x600F7B3")]
				[Address(RVA = "0x2748684", Offset = "0x2748684", VA = "0x7BBCF48684", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600F7B4 RID: 63412 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F7B4")]
			[Address(RVA = "0x274868C", Offset = "0x274868C", VA = "0x7BBCF4868C", Slot = "10")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170011F1 RID: 4593
			// (get) Token: 0x0600F7B5 RID: 63413 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170011F1")]
			private object Current
			{
				[Token(Token = "0x600F7B5")]
				[Address(RVA = "0x27486F4", Offset = "0x27486F4", VA = "0x7BBCF486F4", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600F7B6 RID: 63414 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600F7B6")]
			[Address(RVA = "0x27486FC", Offset = "0x27486FC", VA = "0x7BBCF486FC", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> GetEnumerator()
			{
				return null;
			}

			// Token: 0x0600F7B7 RID: 63415 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600F7B7")]
			[Address(RVA = "0x27487AC", Offset = "0x27487AC", VA = "0x7BBCF487AC", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x04011B5E RID: 72542
			[Token(Token = "0x4011B5E")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04011B5F RID: 72543
			[Token(Token = "0x4011B5F")]
			[FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			// Token: 0x04011B60 RID: 72544
			[Token(Token = "0x4011B60")]
			[FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			// Token: 0x04011B61 RID: 72545
			[Token(Token = "0x4011B61")]
			[FieldOffset(Offset = "0x28")]
			public JSONObject <>4__this;

			// Token: 0x04011B62 RID: 72546
			[Token(Token = "0x4011B62")]
			[FieldOffset(Offset = "0x30")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;
		}
	}
}
