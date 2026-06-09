using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay
{
	// Token: 0x02002A3A RID: 10810
	[Token(Token = "0x2002A3A")]
	internal interface AbDr`s
	{
		// Token: 0x0600E80E RID: 59406
		[Token(Token = "0x600E80E")]
		List<Vector3> GetBoundingBoxList();

		// Token: 0x0600E80F RID: 59407
		[Token(Token = "0x600E80F")]
		GameObject GetGameObject();

		// Token: 0x17000FB5 RID: 4021
		// (get) Token: 0x0600E810 RID: 59408
		[Token(Token = "0x17000FB5")]
		{QAb\u0082~u {QAb\u0082~u { [Token(Token = "0x600E810")] get; }

		// Token: 0x0600E811 RID: 59409
		[Token(Token = "0x600E811")]
		bool IsInVehicle();

		// Token: 0x0600E812 RID: 59410
		[Token(Token = "0x600E812")]
		Vehicle VehicleIAmIn();

		// Token: 0x0600E813 RID: 59411
		[Token(Token = "0x600E813")]
		bool IsPassengerInVehicleCanFire();

		// Token: 0x0600E814 RID: 59412
		[Token(Token = "0x600E814")]
		bool IsOnStrop();

		// Token: 0x0600E815 RID: 59413
		[Token(Token = "0x600E815")]
		bool IsOnChair();

		// Token: 0x0600E816 RID: 59414
		[Token(Token = "0x600E816")]
		bool IsInCatapult();

		// Token: 0x0600E817 RID: 59415
		[Token(Token = "0x600E817")]
		bool IsOnGrapplingHook();

		// Token: 0x0600E818 RID: 59416
		[Token(Token = "0x600E818")]
		bool IsOnHook();

		// Token: 0x0600E819 RID: 59417
		[Token(Token = "0x600E819")]
		bool IsOnVMEHook();

		// Token: 0x0600E81A RID: 59418
		[Token(Token = "0x600E81A")]
		bool HasGrapplingHook();

		// Token: 0x0600E81B RID: 59419
		[Token(Token = "0x600E81B")]
		bool HasHook();

		// Token: 0x0600E81C RID: 59420
		[Token(Token = "0x600E81C")]
		bool HasVMEHook();

		// Token: 0x0600E81D RID: 59421
		[Token(Token = "0x600E81D")]
		LevelStrop GetStropIAmOn();

		// Token: 0x0600E81E RID: 59422
		[Token(Token = "0x600E81E")]
		AHtazwI GetItemOnHand();

		// Token: 0x0600E81F RID: 59423
		[Token(Token = "0x600E81F")]
		AHtazwI GetRealItemOnHand();

		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x0600E820 RID: 59424
		[Token(Token = "0x17000FB6")]
		\u0081{oGdwC A^^}l^H { [Token(Token = "0x600E820")] get; }

		// Token: 0x0600E821 RID: 59425
		[Token(Token = "0x600E821")]
		bool HasHeuristicTarget();

		// Token: 0x0600E822 RID: 59426
		[Token(Token = "0x600E822")]
		bool IsTargetFriend(\u0081{oGdwC VT`lIxO);

		// Token: 0x0600E823 RID: 59427
		[Token(Token = "0x600E823")]
		bool GetSightingState();

		// Token: 0x0600E824 RID: 59428
		[Token(Token = "0x600E824")]
		bool IsSightingUIAvailable();

		// Token: 0x0600E825 RID: 59429
		[Token(Token = "0x600E825")]
		void OnSightingUIStateChange(bool Xxi|B^k, float jIVHyjd);

		// Token: 0x17000FB7 RID: 4023
		// (get) Token: 0x0600E826 RID: 59430
		[Token(Token = "0x17000FB7")]
		Player ]~m^~G\u0080 { [Token(Token = "0x600E826")] get; }
	}
}
