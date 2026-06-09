using System;
using System.Text;
using Il2CppDummyDll;

namespace GarenaMSDKUnity.SimpleJSON
{
	// Token: 0x02002BB8 RID: 11192
	[Token(Token = "0x2002BB8")]
	public class JSONString : JSONNode
	{
		// Token: 0x170011F2 RID: 4594
		// (get) Token: 0x0600F7B8 RID: 63416 RVA: 0x00047358 File Offset: 0x00045558
		[Token(Token = "0x170011F2")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x600F7B8")]
			[Address(RVA = "0x27487B0", Offset = "0x27487B0", VA = "0x7BBCF487B0", Slot = "4")]
			get
			{
				return (JSONNodeType)0;
			}
		}

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x0600F7B9 RID: 63417 RVA: 0x00047370 File Offset: 0x00045570
		[Token(Token = "0x170011F3")]
		public override bool IsString
		{
			[Token(Token = "0x600F7B9")]
			[Address(RVA = "0x27487B8", Offset = "0x27487B8", VA = "0x7BBCF487B8", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F7BA RID: 63418 RVA: 0x00047388 File Offset: 0x00045588
		[Token(Token = "0x600F7BA")]
		[Address(RVA = "0x27487C0", Offset = "0x27487C0", VA = "0x7BBCF487C0", Slot = "28")]
		public override JSONNode.Enumerator GetEnumerator()
		{
			return default(JSONNode.Enumerator);
		}

		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x0600F7BB RID: 63419 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F7BC RID: 63420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170011F4")]
		public override string Value
		{
			[Token(Token = "0x600F7BB")]
			[Address(RVA = "0x27487E0", Offset = "0x27487E0", VA = "0x7BBCF487E0", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600F7BC")]
			[Address(RVA = "0x27487E8", Offset = "0x27487E8", VA = "0x7BBCF487E8", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x0600F7BD RID: 63421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7BD")]
		[Address(RVA = "0x27452D0", Offset = "0x27452D0", VA = "0x7BBCF452D0")]
		public JSONString(string aData)
		{
		}

		// Token: 0x0600F7BE RID: 63422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7BE")]
		[Address(RVA = "0x27487F0", Offset = "0x27487F0", VA = "0x7BBCF487F0", Slot = "27")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		// Token: 0x0600F7BF RID: 63423 RVA: 0x000473A0 File Offset: 0x000455A0
		[Token(Token = "0x600F7BF")]
		[Address(RVA = "0x27488C4", Offset = "0x27488C4", VA = "0x7BBCF488C4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600F7C0 RID: 63424 RVA: 0x000473B8 File Offset: 0x000455B8
		[Token(Token = "0x600F7C0")]
		[Address(RVA = "0x27489E0", Offset = "0x27489E0", VA = "0x7BBCF489E0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04011B63 RID: 72547
		[Token(Token = "0x4011B63")]
		[FieldOffset(Offset = "0x10")]
		private string m_Data;
	}
}
