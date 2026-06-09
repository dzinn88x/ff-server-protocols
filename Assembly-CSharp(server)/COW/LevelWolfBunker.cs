using System;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001270 RID: 4720
	[Token(Token = "0x2001270")]
	public class LevelWolfBunker : BaseLevelObject
	{
		// Token: 0x06004911 RID: 18705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004911")]
		[Address(RVA = "0x1402DE8", Offset = "0x1402DE8", VA = "0x7BBBC02DE8", Slot = "32")]
		protected override string GetObjectTag()
		{
			return null;
		}

		// Token: 0x06004912 RID: 18706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004912")]
		[Address(RVA = "0x1402E30", Offset = "0x1402E30", VA = "0x7BBBC02E30", Slot = "11")]
		protected override void OnAwake()
		{
		}

		// Token: 0x06004913 RID: 18707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004913")]
		[Address(RVA = "0x1402F54", Offset = "0x1402F54", VA = "0x7BBBC02F54", Slot = "13")]
		protected override void OnOnDestroy()
		{
		}

		// Token: 0x06004914 RID: 18708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004914")]
		[Address(RVA = "0x1403020", Offset = "0x1403020", VA = "0x7BBBC03020")]
		private void OnRoleChange(params object[] data)
		{
		}

		// Token: 0x06004915 RID: 18709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004915")]
		[Address(RVA = "0x140314C", Offset = "0x140314C", VA = "0x7BBBC0314C")]
		public void OnLocalPlayerEnter()
		{
		}

		// Token: 0x06004916 RID: 18710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004916")]
		[Address(RVA = "0x14033C8", Offset = "0x14033C8", VA = "0x7BBBC033C8")]
		public void OnLocalPlayerExit()
		{
		}

		// Token: 0x06004917 RID: 18711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004917")]
		[Address(RVA = "0x1403678", Offset = "0x1403678", VA = "0x7BBBC03678")]
		public LevelWolfBunker()
		{
		}

		// Token: 0x04007210 RID: 29200
		[Token(Token = "0x4007210")]
		[FieldOffset(Offset = "0x68")]
		public GameObject wolfHighlight;

		// Token: 0x04007211 RID: 29201
		[Token(Token = "0x4007211")]
		[FieldOffset(Offset = "0x70")]
		public GameObject highlight;
	}
}
