using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.HUD
{
	// Token: 0x02002680 RID: 9856
	[Token(Token = "0x2002680")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FE560", Offset = "0x10FE560")]
	internal class UIHudVehicleAsMissileTargetControllerBase : UIHudVehiclePosControllerBase
	{
		// Token: 0x0600CBD8 RID: 52184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBD8")]
		[Address(RVA = "0x1848470", Offset = "0x1848470", VA = "0x7BBC048470", Slot = "36")]
		protected override void eZ\u0081dunt([Optional] UnityEngine.Object KE`SW[H)
		{
		}

		// Token: 0x0600CBD9 RID: 52185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBD9")]
		[Address(RVA = "0x1848564", Offset = "0x1848564", VA = "0x7BBC048564")]
		internal void \u0081d(LevelMissileBase qVtLkUt)
		{
		}

		// Token: 0x0600CBDA RID: 52186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBDA")]
		[Address(RVA = "0x1848610", Offset = "0x1848610", VA = "0x7BBC048610")]
		internal void RF(LevelMissileBase qVtLkUt)
		{
		}

		// Token: 0x0600CBDB RID: 52187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBDB")]
		[Address(RVA = "0x1848700", Offset = "0x1848700", VA = "0x7BBC048700", Slot = "37")]
		public virtual void SetAsAimTarget(bool K`OU\u0080vI, params object[] QmG~NaB)
		{
		}

		// Token: 0x0600CBDC RID: 52188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBDC")]
		[Address(RVA = "0x18487B4", Offset = "0x18487B4", VA = "0x7BBC0487B4", Slot = "33")]
		public override void RecycleUI()
		{
		}

		// Token: 0x0600CBDD RID: 52189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBDD")]
		[Address(RVA = "0x18488D8", Offset = "0x18488D8", VA = "0x7BBC0488D8")]
		public UIHudVehicleAsMissileTargetControllerBase()
		{
		}

		// Token: 0x04010001 RID: 65537
		[Token(Token = "0x4010001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		protected List<LevelMissileBase> ]awrjpd;

		// Token: 0x04010002 RID: 65538
		[Token(Token = "0x4010002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		protected bool mI~\u007FJwU;
	}
}
