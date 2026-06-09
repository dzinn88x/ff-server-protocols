using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x0200284E RID: 10318
	[Token(Token = "0x200284E")]
	internal class LevelDummy : LevelObjectSpawnedAttackable
	{
		// Token: 0x0600D999 RID: 55705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D999")]
		[Address(RVA = "0x1EA96D8", Offset = "0x1EA96D8", VA = "0x7BBC6A96D8", Slot = "36")]
		protected override void v~u|lmI(CSVBaseData {S]NU\u0082l)
		{
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x0600D99A RID: 55706 RVA: 0x0003C258 File Offset: 0x0003A458
		[Token(Token = "0x17000EC9")]
		public override int |eLiCTf
		{
			[Token(Token = "0x600D99A")]
			[Address(RVA = "0x1EA9AA0", Offset = "0x1EA9AA0", VA = "0x7BBC6A9AA0", Slot = "58")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600D99B RID: 55707 RVA: 0x0003C270 File Offset: 0x0003A470
		[Token(Token = "0x600D99B")]
		[Address(RVA = "0x1EA9ACC", Offset = "0x1EA9ACC", VA = "0x7BBC6A9ACC", Slot = "62")]
		public override Vector3 GetAttackableCenterWS()
		{
			return default(Vector3);
		}

		// Token: 0x0600D99C RID: 55708 RVA: 0x0003C288 File Offset: 0x0003A488
		[Token(Token = "0x600D99C")]
		[Address(RVA = "0x1EA9B84", Offset = "0x1EA9B84", VA = "0x7BBC6A9B84")]
		public ResourceID GetHitSound()
		{
			return default(ResourceID);
		}

		// Token: 0x0600D99D RID: 55709 RVA: 0x0003C2A0 File Offset: 0x0003A4A0
		[Token(Token = "0x600D99D")]
		[Address(RVA = "0x1EA9BB0", Offset = "0x1EA9BB0", VA = "0x7BBC6A9BB0", Slot = "64")]
		public override bool NeedAssit()
		{
			return default(bool);
		}

		// Token: 0x0600D99E RID: 55710 RVA: 0x0003C2B8 File Offset: 0x0003A4B8
		[Token(Token = "0x600D99E")]
		[Address(RVA = "0x1EA9BDC", Offset = "0x1EA9BDC", VA = "0x7BBC6A9BDC", Slot = "65")]
		public override bool IsSameTeamWithPlayerID({QAb\u0082~u hVZ^Lay)
		{
			return default(bool);
		}

		// Token: 0x0600D99F RID: 55711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D99F")]
		[Address(RVA = "0x1EA9BE4", Offset = "0x1EA9BE4", VA = "0x7BBC6A9BE4", Slot = "32")]
		protected override string GetObjectTag()
		{
			return null;
		}

		// Token: 0x0600D9A0 RID: 55712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9A0")]
		[Address(RVA = "0x1EA9C2C", Offset = "0x1EA9C2C", VA = "0x7BBC6A9C2C", Slot = "27")]
		public override void SyncAction(params object[] OSvO{nh)
		{
		}

		// Token: 0x0600D9A1 RID: 55713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D9A1")]
		[Address(RVA = "0x1EAA3AC", Offset = "0x1EAA3AC", VA = "0x7BBC6AA3AC")]
		public LevelDummy()
		{
		}

		// Token: 0x040109A6 RID: 68006
		[Token(Token = "0x40109A6")]
		[FieldOffset(Offset = "0xA0")]
		public Transform FireEffectContainer;

		// Token: 0x040109A7 RID: 68007
		[Token(Token = "0x40109A7")]
		[FieldOffset(Offset = "0xA8")]
		private <<EMPTY_NAME>> d\u0082o{Q}E;
	}
}
