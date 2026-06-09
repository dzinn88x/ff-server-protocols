using System;
using System.Text;
using Il2CppDummyDll;

namespace GarenaMSDKUnity.SimpleJSON
{
	// Token: 0x02002BBC RID: 11196
	[Token(Token = "0x2002BBC")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x10FF78C", Offset = "0x10FF78C")]
	internal class JSONLazyCreator : JSONNode
	{
		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x0600F7E7 RID: 63463 RVA: 0x00047598 File Offset: 0x00045798
		[Token(Token = "0x17001201")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x600F7E7")]
			[Address(RVA = "0x2743EC8", Offset = "0x2743EC8", VA = "0x7BBCF43EC8", Slot = "4")]
			get
			{
				return (JSONNodeType)0;
			}
		}

		// Token: 0x0600F7E8 RID: 63464 RVA: 0x000475B0 File Offset: 0x000457B0
		[Token(Token = "0x600F7E8")]
		[Address(RVA = "0x2743ED0", Offset = "0x2743ED0", VA = "0x7BBCF43ED0", Slot = "28")]
		public override JSONNode.Enumerator GetEnumerator()
		{
			return default(JSONNode.Enumerator);
		}

		// Token: 0x0600F7E9 RID: 63465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7E9")]
		[Address(RVA = "0x2742DE4", Offset = "0x2742DE4", VA = "0x7BBCF42DE4")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		// Token: 0x0600F7EA RID: 63466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7EA")]
		[Address(RVA = "0x2743EF0", Offset = "0x2743EF0", VA = "0x7BBCF43EF0")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		// Token: 0x0600F7EB RID: 63467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7EB")]
		[Address(RVA = "0x2743F70", Offset = "0x2743F70", VA = "0x7BBCF43F70")]
		private void Set(JSONNode aVal)
		{
		}

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x0600F7EC RID: 63468 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F7ED RID: 63469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001202")]
		public override JSONNode Item
		{
			[Token(Token = "0x600F7EC")]
			[Address(RVA = "0x2743FF4", Offset = "0x2743FF4", VA = "0x7BBCF43FF4", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x600F7ED")]
			[Address(RVA = "0x2744054", Offset = "0x2744054", VA = "0x7BBCF44054", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x0600F7EE RID: 63470 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F7EF RID: 63471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001203")]
		public override JSONNode Item
		{
			[Token(Token = "0x600F7EE")]
			[Address(RVA = "0x27440E4", Offset = "0x27440E4", VA = "0x7BBCF440E4", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x600F7EF")]
			[Address(RVA = "0x2744154", Offset = "0x2744154", VA = "0x7BBCF44154", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x0600F7F0 RID: 63472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7F0")]
		[Address(RVA = "0x274427C", Offset = "0x274427C", VA = "0x7BBCF4427C", Slot = "21")]
		public override void Add(JSONNode aItem)
		{
		}

		// Token: 0x0600F7F1 RID: 63473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F7F1")]
		[Address(RVA = "0x274430C", Offset = "0x274430C", VA = "0x7BBCF4430C", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		// Token: 0x0600F7F2 RID: 63474 RVA: 0x000475C8 File Offset: 0x000457C8
		[Token(Token = "0x600F7F2")]
		[Address(RVA = "0x27443A4", Offset = "0x27443A4", VA = "0x7BBCF443A4")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		// Token: 0x0600F7F3 RID: 63475 RVA: 0x000475E0 File Offset: 0x000457E0
		[Token(Token = "0x600F7F3")]
		[Address(RVA = "0x27443BC", Offset = "0x27443BC", VA = "0x7BBCF443BC")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		// Token: 0x0600F7F4 RID: 63476 RVA: 0x000475F8 File Offset: 0x000457F8
		[Token(Token = "0x600F7F4")]
		[Address(RVA = "0x27443D4", Offset = "0x27443D4", VA = "0x7BBCF443D4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600F7F5 RID: 63477 RVA: 0x00047610 File Offset: 0x00045810
		[Token(Token = "0x600F7F5")]
		[Address(RVA = "0x27443EC", Offset = "0x27443EC", VA = "0x7BBCF443EC", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x0600F7F6 RID: 63478 RVA: 0x00047628 File Offset: 0x00045828
		// (set) Token: 0x0600F7F7 RID: 63479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001204")]
		public override int AsInt
		{
			[Token(Token = "0x600F7F6")]
			[Address(RVA = "0x27443F4", Offset = "0x27443F4", VA = "0x7BBCF443F4", Slot = "31")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600F7F7")]
			[Address(RVA = "0x27444DC", Offset = "0x27444DC", VA = "0x7BBCF444DC", Slot = "32")]
			set
			{
			}
		}

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x0600F7F8 RID: 63480 RVA: 0x00047640 File Offset: 0x00045840
		// (set) Token: 0x0600F7F9 RID: 63481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001205")]
		public override float AsFloat
		{
			[Token(Token = "0x600F7F8")]
			[Address(RVA = "0x274454C", Offset = "0x274454C", VA = "0x7BBCF4454C", Slot = "33")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600F7F9")]
			[Address(RVA = "0x27445B8", Offset = "0x27445B8", VA = "0x7BBCF445B8", Slot = "34")]
			set
			{
			}
		}

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x0600F7FA RID: 63482 RVA: 0x00047658 File Offset: 0x00045858
		// (set) Token: 0x0600F7FB RID: 63483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001206")]
		public override double AsDouble
		{
			[Token(Token = "0x600F7FA")]
			[Address(RVA = "0x2744628", Offset = "0x2744628", VA = "0x7BBCF44628", Slot = "29")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x600F7FB")]
			[Address(RVA = "0x2744694", Offset = "0x2744694", VA = "0x7BBCF44694", Slot = "30")]
			set
			{
			}
		}

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x0600F7FC RID: 63484 RVA: 0x00047670 File Offset: 0x00045870
		// (set) Token: 0x0600F7FD RID: 63485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001207")]
		public override bool AsBool
		{
			[Token(Token = "0x600F7FC")]
			[Address(RVA = "0x2744704", Offset = "0x2744704", VA = "0x7BBCF44704", Slot = "35")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600F7FD")]
			[Address(RVA = "0x2744770", Offset = "0x2744770", VA = "0x7BBCF44770", Slot = "36")]
			set
			{
			}
		}

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x0600F7FE RID: 63486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001208")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x600F7FE")]
			[Address(RVA = "0x27447E0", Offset = "0x27447E0", VA = "0x7BBCF447E0", Slot = "37")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x0600F7FF RID: 63487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001209")]
		public override JSONObject AsObject
		{
			[Token(Token = "0x600F7FF")]
			[Address(RVA = "0x2744848", Offset = "0x2744848", VA = "0x7BBCF44848", Slot = "38")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F800 RID: 63488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F800")]
		[Address(RVA = "0x27448B0", Offset = "0x27448B0", VA = "0x7BBCF448B0", Slot = "27")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		// Token: 0x04011B68 RID: 72552
		[Token(Token = "0x4011B68")]
		[FieldOffset(Offset = "0x10")]
		private JSONNode m_Node;

		// Token: 0x04011B69 RID: 72553
		[Token(Token = "0x4011B69")]
		[FieldOffset(Offset = "0x18")]
		private string m_Key;
	}
}
