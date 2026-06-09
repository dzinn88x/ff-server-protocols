using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02001010 RID: 4112
	[Token(Token = "0x2001010")]
	public class UI3DObjectHelper : MonoBehaviour
	{
		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06003DAC RID: 15788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000729")]
		public Dictionary<string, Transform> RegistedObjectDict
		{
			[Token(Token = "0x6003DAC")]
			[Address(RVA = "0x202195C", Offset = "0x202195C", VA = "0x7BBC82195C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003DAD RID: 15789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DAD")]
		[Address(RVA = "0x2021BC0", Offset = "0x2021BC0", VA = "0x7BBC821BC0")]
		private void Awake()
		{
		}

		// Token: 0x06003DAE RID: 15790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DAE")]
		[Address(RVA = "0x20219F4", Offset = "0x20219F4", VA = "0x7BBC8219F4")]
		private void RefreshRegistedObjectDict()
		{
		}

		// Token: 0x06003DAF RID: 15791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DAF")]
		[Address(RVA = "0x2021BC4", Offset = "0x2021BC4", VA = "0x7BBC821BC4")]
		public Transform GetRegistedObjectWithName(string name)
		{
			return null;
		}

		// Token: 0x06003DB0 RID: 15792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DB0")]
		[Address(RVA = "0x2021CA4", Offset = "0x2021CA4", VA = "0x7BBC821CA4")]
		public UI3DObjectHelper()
		{
		}

		// Token: 0x04004E72 RID: 20082
		[Token(Token = "0x4004E72")]
		[FieldOffset(Offset = "0x18")]
		public Transform[] RegistedObjects;

		// Token: 0x04004E73 RID: 20083
		[Token(Token = "0x4004E73")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, Transform> m_RegistedObjectDict;
	}
}
