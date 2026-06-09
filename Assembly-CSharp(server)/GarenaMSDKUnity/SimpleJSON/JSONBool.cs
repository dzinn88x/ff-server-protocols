using System;
using System.Text;
using Il2CppDummyDll;

namespace GarenaMSDKUnity.SimpleJSON
{
	// Token: 0x02002BBA RID: 11194
	[Token(Token = "0x2002BBA")]
	public class JSONBool : JSONNode
	{
		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x0600F7CE RID: 63438 RVA: 0x00047478 File Offset: 0x00045678
		[Token(Token = "0x170011F9")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x600F7CE")]
			[Address(RVA = "0x2743BCC", Offset = "0x2743BCC", VA = "0x7BBCF43BCC", Slot = "4")]
			get
			{
				return (JSONNodeType)0;
			}
		}

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x0600F7CF RID: 63439 RVA: 0x00047490 File Offset: 0x00045690
		[Token(Token = "0x170011FA")]
		public override bool IsBoolean
		{
			[Token(Token = "0x600F7CF")]
			[Address(RVA = "0x2743BD4", Offset = "0x2743BD4", VA = "0x7BBCF43BD4", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F7D0 RID: 63440 RVA: 0x000474A8 File Offset: 0x000456A8
		[Token(Token = "0x600F7D0")]
		[Address(RVA = "0x2743BDC", Offset = "0x2743BDC", VA = "0x7BBCF43BDC", Slot = "28")]
		public override JSONNode.Enumerator GetEnumerator()
		{
			return default(JSONNode.Enumerator);
		}

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x0600F7D1 RID: 63441 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F7D2 RID: 63442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170011FB")]
		public override string Value
		{
			[Token(Token = "0x600F7D1")]
			[Address(RVA = "0x2743BFC", Offset = "0x2743BFC", VA = "0x7BBCF43BFC", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600F7D2")]
			[Address(RVA = "0x2743C08", Offset = "0x2743C08", VA = "0x7BBCF43C08", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x0600F7D3 RID: 63443 RVA: 0x000474C0 File Offset: 0x000456C0
		// (set) Token: 0x0600F7D4 RID: 63444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170011FC")]
		public override bool AsBool
		{
			[Token(Token = "0x600F7D3")]
			[Address(RVA = "0x2743C94", Offset = "0x2743C94", VA = "0x7BBCF43C94", Slot = "35")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600F7D4")]
			[Address(RVA = "0x2743C9C", Offset = "0x2743C9C", VA = "0x7BBCF43C9C", Slot = "36")]
			set
			{
			}
		}

		// Token: 0x0600F7D5 RID: 63445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7D5")]
		[Address(RVA = "0x2743CA8", Offset = "0x2743CA8", VA = "0x7BBCF43CA8")]
		public JSONBool(bool aData)
		{
		}

		// Token: 0x0600F7D6 RID: 63446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7D6")]
		[Address(RVA = "0x2743D28", Offset = "0x2743D28", VA = "0x7BBCF43D28")]
		public JSONBool(string aData)
		{
		}

		// Token: 0x0600F7D7 RID: 63447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7D7")]
		[Address(RVA = "0x2743DB0", Offset = "0x2743DB0", VA = "0x7BBCF43DB0", Slot = "27")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		// Token: 0x0600F7D8 RID: 63448 RVA: 0x000474D8 File Offset: 0x000456D8
		[Token(Token = "0x600F7D8")]
		[Address(RVA = "0x2743E34", Offset = "0x2743E34", VA = "0x7BBCF43E34", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600F7D9 RID: 63449 RVA: 0x000474F0 File Offset: 0x000456F0
		[Token(Token = "0x600F7D9")]
		[Address(RVA = "0x2743EBC", Offset = "0x2743EBC", VA = "0x7BBCF43EBC", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04011B65 RID: 72549
		[Token(Token = "0x4011B65")]
		[FieldOffset(Offset = "0x10")]
		private bool m_Data;
	}
}
